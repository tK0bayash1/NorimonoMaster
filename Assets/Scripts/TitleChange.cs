using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleChange : MonoBehaviour
{
    [SerializeField]
    private Button _gameButton;

    [SerializeField]
    private Button _shopButton;

    [SerializeField]
    private Button _collection;


    // Start is called before the first frame update
    void Start()
    {
        var game = new Button.ButtonClickedEvent(); //gameボタン
        game.AddListener(GameOnClick);
        _gameButton.onClick = game;

        var shop = new Button.ButtonClickedEvent(); //shopボタン
        shop.AddListener(ShopOnClick);
        _shopButton.onClick = shop;

        var collection = new Button.ButtonClickedEvent(); // collectionボタン
        collection.AddListener(CollectionOnClick);
        _collection.onClick = collection;

     

    }

    public void GameOnClick()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShopOnClick()
    {
        SceneManager.LoadScene("Shop");
    }

 
    public void CollectionOnClick()
    {
        SceneManager.LoadScene("Collection");
    }
 
}

