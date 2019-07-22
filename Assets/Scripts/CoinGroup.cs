using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGroup : MonoBehaviour
{
    float offset_X = -20.0f;
    protected void Update()
    {
        if (GameSceneManager.player.transform.position.x + offset_X > transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
