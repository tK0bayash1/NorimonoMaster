using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopChange : MonoBehaviour
{

    [SerializeField]
    private Button _titleButton;

    // Start is called before the first frame update
    void Start()
    {
        var title = new Button.ButtonClickedEvent(); //titleボタン
        title.AddListener(TitleOnClick);
        _titleButton.onClick = title;
    }

    public void TitleOnClick()
    {
        SceneManager.LoadScene("Title");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
