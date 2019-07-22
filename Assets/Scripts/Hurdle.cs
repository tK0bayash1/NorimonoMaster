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

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("アウツ!");
    }

    abstract protected void Move();
}
