using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script;

public class PlayerController : MonoBehaviour
{
    private enum State { Running, Jumping, Landing }
    private State state = State.Running;

    private Rigidbody2D rig;    //
    [SerializeField] private float jumpPower = 10;
    [SerializeField] private int NumberOfAerialJumpTimes = 1;
    [SerializeField] private int jumpTimes = 0;

    private Vehicle vehicle;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        // ジャンプ
        switch (state)
        {
            case State.Running: //走っている
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Jump();

                        state = State.Jumping;
                    }
                }
                break;
            case State.Jumping: //空中にいる
                {
                    if (Input.GetKeyDown(KeyCode.Space) && jumpTimes < NumberOfAerialJumpTimes)
                    {
                        Jump();
                        jumpTimes += 1;
                    }
                }
                break;
            case State.Landing: //着地
                {
                    jumpTimes = 0;

                }
                break;
        }
    }

    private void Jump()
    {
        rig.AddForce(new Vector3(0.0f, -Physics2D.gravity.y * jumpPower, 0.0f));
    }
}
