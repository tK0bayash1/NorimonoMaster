using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMain : MonoBehaviour
{
    static public bool[] BoardingPermission { get; set; } //すでに当たっているかどうか
    public enum Cars { NomalCar, SportsCar, Jeep, Bicycle, MotorBicycle, Excavator, Bulldozer } //車名
    public Cars[] cars = new Cars[7] { Cars.NomalCar, Cars.SportsCar, Cars.Jeep, Cars.Bicycle, Cars.MotorBicycle, Cars.Excavator, Cars.Bulldozer };
    [SerializeField]
    private Sprite[] CarsTexture = new Sprite[7]; //表示用の画像
    [SerializeField]
    private Sprite Box; //初期の画像
    [SerializeField]
    private Text GetName; //入手時のメッセージ
    [SerializeField]
    private Text MoneyText; //所持金表示
    [SerializeField]
    private Text ButtonText;
    [SerializeField]
    private Image Prize; //取得物表示用のオブジェクト
    [SerializeField]
    private CarsStatus carsStatus;
    static public int Money { get; set; } //所持金
    public int Cost;
    public float ShopWaitTime = 0.2f;
    private bool GetFlag;
    private bool Running = false;
    // Start is called before the first frame update

    public IEnumerator DelayMove(float waitTime, int i)
    {
        yield return new WaitForSeconds(waitTime);
        Production(i);

    }
    void Start()
    {
        BoardingPermission = new bool[7];

    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = "所持金 " + Money;
    }

    public void BuyNewCars()
    {
        if (GetFlag == false && Running == false)
        {
            Running = true;
            Money -= Cost;
            GetName.text = "LaLaLaLa...";
            Production(0);
        }
        else if (Running == false)
        {
            carsStatus.UpdateCars();
            Debug.Log(CarsStatus.cars[2].Name);
            Debug.Log(CarsStatus.cars[2].GetFlag);
            Prize.sprite = Box;
            GetName.text = "ButtonClick!";
            ButtonText.text = "Buy!";
            GetFlag = false;
        }

    }


    private void Production(int i)
    {
        int GetItem = Random.Range((int)Cars.NomalCar, (int)Cars.Bulldozer + 1);
        Prize.sprite = CarsTexture[GetItem];
        if (i == 10)
        {
            GetName.text = string.Format("Item :{0} Get!", cars[GetItem]);
            BoardingPermission[GetItem] = true;
            Debug.Log(GetItem);
            carsStatus.carData[GetItem].GetFlag = true;
            GetFlag = true;
            Running = false;
            
            ButtonText.text = "Next";
        }
        else
        {
            i++;
            StartCoroutine(DelayMove(ShopWaitTime, i));
        }
    }
}
