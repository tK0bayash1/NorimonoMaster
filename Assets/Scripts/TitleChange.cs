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


    // Start is called before the first frame update
    void Start()
    {
        var game = new Button.ButtonClickedEvent(); //gameボタン
        game.AddListener(GameOnClick);
        _gameButton.onClick = game;

        var shop = new Button.ButtonClickedEvent(); //shopボタン
        shop.AddListener(ShopOnClick);
        _shopButton.onClick = shop;

     

    }

    public void GameOnClick()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShopOnClick()
    {
        SceneManager.LoadScene("Shop");
    }

 

 
}

