using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] float speed_x;
    Material _mat;
    float offset_x;
    void Start()
    {
        _mat = GetComponent<SpriteRenderer>().material;
        Debug.Log(_mat);
    }
    
    void Update()
    {
        offset_x += speed_x;
        _mat.SetTextureOffset("_MainTex", new Vector2(offset_x, 0));
    }
}
