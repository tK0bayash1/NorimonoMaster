using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionSweeper : MonoBehaviour
{
    PlayerController player;
    Vector3 originPos;
    [SerializeField] float CameraSpeedAdjuster;

    void Start()
    {
        player = GetComponent<PlayerController>();
        originPos = transform.position;
    }

    void Update()
    {
        transform.position = originPos + Vector3.right * player.MovingAmount * CameraSpeedAdjuster;
    }
}
