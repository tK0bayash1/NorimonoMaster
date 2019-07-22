using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int Index { get; set; }
    [SerializeField] float offset_X = -20;

    void Create(int index)
    {
        Index = index;
    }

    void Update()
    {
        if (GameSceneManager.player.transform.position.x + offset_X > transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
