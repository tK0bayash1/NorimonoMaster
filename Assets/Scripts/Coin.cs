using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    float offset_X = -20.0f;

    void Start()
    {

    }

    protected void Update()
    {
        if (GameSceneManager.player.transform.position.x + offset_X > transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ShopMain.Money += 1;
            Destroy(this.gameObject);
        }
    }
}
