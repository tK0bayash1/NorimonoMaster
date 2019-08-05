using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hurdle : MonoBehaviour
{
    [SerializeField]
    Sprite _sprite;
    [SerializeField] float offset_X = -20;

    protected void Start()
    {
        GetComponent<SpriteRenderer>().sprite = _sprite;
    }

    protected void Update()
    {
        if (GameSceneManager.player.transform.position.x + offset_X > transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameSceneManager.player.GameOver();
        }
    }

    abstract protected void Move();
}
