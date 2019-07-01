using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hurdle : MonoBehaviour
{
    [SerializeField]
    Sprite _sprite;

    protected void Start()
    {
        GetComponent<SpriteRenderer>().sprite = _sprite;
    }

    protected void Update()
    {
        if (HurdleSystem.Player.transform.position.x > transform.position.x)
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
