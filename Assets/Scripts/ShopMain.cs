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
    private Text GetName; //入手時のメッセージ
    [SerializeField]
    private Image Prize; //取得物表示用のオブジェクト
    static public int Money { get; set; } //所持金
    public int Cost;
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

    }

    public void BuyNewCars()
    {
        Money -= Cost;
        GetName.text = "LaLaLaLa...";
        Production(0);

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
        }
        else
        {
            i++;
            StartCoroutine(DelayMove(0.2f, i));
        }
    }
}
