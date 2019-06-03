using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleSystem : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] Hurdle[] hurdleTypes;

    void Start()
    {
        GameObject.Instantiate(hurdleTypes[0]);
    }

    void Update()
    {
        
    }
}
