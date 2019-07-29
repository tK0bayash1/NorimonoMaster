using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectionManager : MonoBehaviour
{
    [SerializeField]
    private Button _title;

    [SerializeField]
    private Button _bicycle;

    [SerializeField]
    private Button _jeep;

    [SerializeField]
    private Button _nomalcar;

    [SerializeField]
    private Button _sportcar;

    [SerializeField]
    private Button _motorcycle;

    [SerializeField]
    private Button _excavator;

    [SerializeField]
    private Button _bulldozer;

    [SerializeField]
    private Button _cancel;

    [SerializeField]
    private GameObject _collection;

    [SerializeField]
    private Image _image;

    [SerializeField]
    private Sprite _bictex;

    [SerializeField]
    private Sprite _nomaltex;

    [SerializeField]
    private Sprite _sporttex;

    [SerializeField]
    private Sprite _motortex;

    [SerializeField]
    private Sprite _excatex;

    [SerializeField]
    private Sprite _bulltex;

    [SerializeField]
    private Sprite _jeeptex;

    [SerializeField]
    private Text _text;

    private float distance;



    // Start is called before the first frame update
    void Start()
    {
        var title = new Button.ButtonClickedEvent(); //titleボタン
        title.AddListener(TitleOnClick);
        _title.onClick = title;

        var bicycle = new Button.ButtonClickedEvent(); //Bicycleボタン
        bicycle.AddListener(BicycleOnClick);
        _bicycle.onClick = bicycle;

        var jeep = new Button.ButtonClickedEvent(); //jeep
        jeep.AddListener(JeepOnClick);
        _jeep.onClick = jeep;

        var nomarCar = new Button.ButtonClickedEvent(); //car
        nomarCar.AddListener(NomalCarOnClick);
        _nomalcar.onClick = nomarCar;

        var sportCar = new Button.ButtonClickedEvent(); //sport
        sportCar.AddListener(SportCarOnClick);
        _sportcar.onClick = sportCar;

        var motorcycle = new Button.ButtonClickedEvent(); //motor
        motorcycle.AddListener(MotorcycleOnClick);
        _motorcycle.onClick = motorcycle;

        var excavator = new Button.ButtonClickedEvent(); //excavator
        excavator.AddListener(ExcavatorOnClick);
        _excavator.onClick = excavator;

        var bulldozer = new Button.ButtonClickedEvent(); //bulldozer
        bulldozer.AddListener(BulldozerOnClick);
        _bulldozer.onClick = bulldozer;

        var cancel = new Button.ButtonClickedEvent(); //cancel
        cancel.AddListener(CancelOnClick);
        _cancel.onClick = cancel;

        _collection.gameObject.SetActive(false); //実績画面

     

    }


    public void TitleOnClick()
    {
        SceneManager.LoadScene("Title");
    }
   
    public void BicycleOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _bictex;
     //   distance = CarsStatus.cars[0].distance;
        _text.text = "自転車の総移動距離\n" + distance + "km";
        
    }

    public void NomalCarOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _nomaltex;
        _text.text = "普通車の総移動距離\n" + distance + "km";
    }

    public void SportCarOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _sporttex;
        _text.text = "スポーツカーの総移動距離\n" + distance + "km";
    }

    public void JeepOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _jeeptex;
        _text.text = "ジープの総移動距離\n" + distance + "km";
    }

    public void MotorcycleOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _motortex;
        _text.text = "バイクの総移動距離\n" + distance + "km";
    }

    public void ExcavatorOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _excatex;
        _text.text = "ショベルカーの総移動距離\n" + distance + "km";
    }

    public void BulldozerOnClick()
    {
        _collection.gameObject.SetActive(true);
        _image.sprite = _bulltex;
        _text.text = "ブルドーザーの総移動距離\n" + distance + "km";
    }

    public void CancelOnClick()
    {
        _collection.gameObject.SetActive(false);
    }

}
