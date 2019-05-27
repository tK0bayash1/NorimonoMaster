using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
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
        var game = new Button.ButtonClickedEvent();  //gameボタン処理
        game.AddListener(GameOnClick);
        _gameButton.onClick = game;
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
