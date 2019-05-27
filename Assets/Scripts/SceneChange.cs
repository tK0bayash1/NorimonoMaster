using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    [SerializeField]
    private Button _gameButton;

    [SerializeField]
    private Button _shopButton;

    [SerializeField]
    private Button _titleButton;

    // Start is called before the first frame update
    void Start()
    {
        var game = new Button.ButtonClickedEvent(); //gameボタン
        game.AddListener(GameOnClick);
        _gameButton.onClick = game;

        var shop = new Button.ButtonClickedEvent(); //shopボタン
        shop.AddListener(ShopOnClick);
        _shopButton.onClick = shop;

        var title = new Button.ButtonClickedEvent(); //titleボタン
        title.AddListener(TitleOnClick);
        _titleButton.onClick = title;

    }

    public void GameOnClick()
    {

    }

    public void ShopOnClick()
    {

    }

    public void TitleOnClick()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
