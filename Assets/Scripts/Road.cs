using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    float dis_x;
    [SerializeField] GameObject[] children;
    int leftIndex;
    [SerializeField] float offset = 15;
    void Start()
    {
        leftIndex = 0;
        dis_x = children[1].transform.position.x - children[0].transform.position.x;
    }
    
    void Update()
    {
        if(GameSceneManager.player.transform.position.x > children[leftIndex].transform.position.x + offset)
        {
            children[leftIndex].transform.position += Vector3.right * 2 * dis_x;
            leftIndex = leftIndex ^ 1;
        }
    }
}
