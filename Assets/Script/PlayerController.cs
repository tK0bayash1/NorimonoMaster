using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private enum State { Running, Jumping, Landing, Transferring }
    private State state = State.Running;

    private Rigidbody2D rig;
    [SerializeField] private int currentJumpNum = 0;  // 現在のジャンプ回数
    [SerializeField] private float jumpPower = 1.0f;   // ジャンプ力
    [SerializeField] private float movingAmount = 0;    // 移動量
    public float MovingAmount { get { return movingAmount; } } 
    
    private int vehicleIndex; // 乗り物の配列番号

    void Start()
    {
        if (GetComponent<BoxCollider2D>() == null) gameObject.AddComponent<BoxCollider2D>();    // コライダーがあるかどうか
        rig = GetComponent<Rigidbody2D>();  // rigidbodyの取得
        if (rig == null) rig = gameObject.AddComponent<Rigidbody2D>();  // rigidbodyの取得チェック

        vehicleIndex = 0; // 最初の乗り物
    }

    void Update()
    {
        switch (state)
        {
            case State.Running: //走っている
                {
                    Move();
                    if (Input.GetKeyDown(KeyCode.Space))    // ジャンプ
                    {
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
                }
                break;
            case State.Landing: //着地
                {
                }
                break;
            case State.Transferring:    // 乗り換え
                {
                }
                break;
        }
    }

    // ジャンプ
    private bool Jump()
    {
        if (currentJumpNum < CarsStatus.cars[vehicleIndex].JumpNum)    // ジャンプ回数が限界を超えているか
        {
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
        currentJumpNum = 0;
        state = State.Running;
    }

    // 移動
    private void Move()
    {
        movingAmount += CarsStatus.cars[vehicleIndex].Speed * Time.deltaTime;
    }

    // 乗り換え
    private void Transfer()
    {
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
        if (other.tag == "Vehicle") // 乗り物オブジェクトに接触したら
        {

            vehicleIndex = other.GetComponent<Item>().Index;    // 新しいVehicleに乗り換え
            state = State.Transferring;
        }
    }
}
