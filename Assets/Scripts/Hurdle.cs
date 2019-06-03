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
        Move();
    }

    abstract protected void Move();
}
