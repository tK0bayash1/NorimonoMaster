using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int Index { get; set; }
    [SerializeField] float offset_X = -20;
    public Sprite CarImage { get; private set; }

    public void Create(int index, Sprite image)
    {
        Index = index;
        CarImage = image;
    }

    void Update()
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
            var player = other.GetComponent<PlayerController>();
            if (!player) Debug.Log("???");
            else player.Transfer(this);
            Destroy(this.gameObject);
        }
    }
}
