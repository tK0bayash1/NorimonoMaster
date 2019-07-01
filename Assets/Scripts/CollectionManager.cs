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
    }

    public void NomalCarOnClick()
    {
        _collection.gameObject.SetActive(true);
    }

    public void SportCarOnClick()
    {
        _collection.gameObject.SetActive(true);
    }

    public void JeepOnClick()
    {
        _collection.gameObject.SetActive(true);
    }

    public void MotorcycleOnClick()
    {
        _collection.gameObject.SetActive(true);
    }

    public void ExcavatorOnClick()
    {
        _collection.gameObject.SetActive(true);
    }

    public void BulldozerOnClick()
    {
        _collection.gameObject.SetActive(true);
    }

    public void CancelOnClick()
    {
        _collection.gameObject.SetActive(false);
    }

}
