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
        offset_x += offset_x < 1.0f ? 0 : -1.0f;
        _mat.SetTextureOffset("_MainTex", new Vector2(offset_x, 0));
    }
}
