using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private enum State { Running, Jumping, Landing, Transferring, GameOver }
    [SerializeField] private State state = State.Running;    // プレイヤーのステータス

    [SerializeField] InGameAudioManager audioManager;
    private Rigidbody2D rig;
    private BoxCollider2D collider;
    [SerializeField] private int currentJumpNum = 0;  // 現在のジャンプ回数
    [SerializeField] private float jumpPower = 1.0f;   // ジャンプ力
    [SerializeField] private float movingAmount = 0;    // 移動量
    public float MovingAmount { get { return movingAmount; } }
    [SerializeField] private float moveSpeedAjuster = 1.0f;

    [HideInInspector] public int vehicleIndex; // 乗り物の配列番号
    [SerializeField] private int startingVehicle = 0;

    //[SerializeField] private bool moveWithCamera = true;
    private float defaultY;

    private SpriteRenderer sprite;

    void Start()
    {
        if (GetComponent<BoxCollider2D>() == null) gameObject.AddComponent<BoxCollider2D>();    // コライダーがあるかどうか
        rig = GetComponent<Rigidbody2D>();  // rigidbodyの取得
        if (rig == null) rig = gameObject.AddComponent<Rigidbody2D>();  // rigidbodyの取得チェック
        rig.constraints = RigidbodyConstraints2D.FreezePositionY;
        collider = GetComponent<BoxCollider2D>();

        vehicleIndex = startingVehicle; // 最初の乗り物

        defaultY = transform.position.y;

        sprite = this.gameObject.GetComponent<SpriteRenderer>();    // 表示させるsprite
    }

    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.L)) { Debug.Log(CarsStatus.cars[vehicleIndex].JumpNum); }
        if (Input.GetKeyDown(KeyCode.R)) { GameOver(); }
#endif
        switch (state)
        {
            case State.Running: //走っている
                {
                    Move();
                    if (Input.GetKeyDown(KeyCode.Space))    // ジャンプ
                    {
                        audioManager.Jump.Play();
                        Jump();
                    }
                }
                break;
            case State.Jumping: //空中にいる
                {
                    Move();
                    if (Input.GetKeyDown(KeyCode.Space))    // 空中ジャンプ
                    {
                        Jump();
                    }
                    if (transform.position.y <= defaultY)    // 地面に埋まったら
                    {
                        Land();
                    }
                }
                break;
            case State.Landing: //着地
                {
                }
                break;
            case State.Transferring:    // 乗り換え
                {
                    state = State.Running;
                }
                break;
            case State.GameOver:
                {
                    Move();
                }
                break;
        }
    }

    // ジャンプ
    private bool Jump()
    {
        if (currentJumpNum < CarsStatus.cars[vehicleIndex].JumpNum)    // ジャンプ回数が限界を超えているか
        {
            rig.constraints = RigidbodyConstraints2D.None;

            currentJumpNum += 1;
            rig.velocity = (new Vector3(0.0f, jumpPower));
            state = State.Jumping;
            return true;
        }
        else return false;
    }

    // 着地
    private void Land()
    {
        rig.constraints = RigidbodyConstraints2D.FreezePositionY;
        float x = transform.position.x;
        transform.position = new Vector2(x, defaultY);

        currentJumpNum = 0;
        state = State.Running;
    }

    // 移動
    private void Move()
    {
        float amount = CarsStatus.cars[vehicleIndex].Speed * Time.deltaTime * moveSpeedAjuster;
        transform.Translate(new Vector2(amount, 0));
        movingAmount += amount;
    }

    // 乗り換え
    public void Transfer(Item hit)
    {
        vehicleIndex = hit.Index;
        GetComponent<SpriteRenderer>().sprite = hit.CarImage;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Respawn")    // 地面に接触したら
        {
            Land();
            state = State.Running;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.tag == "Vehicle") // 乗り物オブジェクトに接触したら
        //{
        //    vehicleIndex = other.GetComponent<Item>().Index;    // 新しいVehicleに乗り換え
        //    state = State.Transferring;
        //}
    }

    public void GameOver()
    {
        state = State.GameOver;
        sprite.enabled = false;
        collider.enabled = false;
        
        ResultManager.resultWindow.ShowResult(movingAmount);
        CarsStatus.cars[vehicleIndex].Distance += movingAmount;
    }
}
