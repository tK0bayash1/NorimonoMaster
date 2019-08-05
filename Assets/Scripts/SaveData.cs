using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public class Data
    {
        [SerializeField]
        private CarsStatus.CarData[] CarDatas;
        [SerializeField]
        private int Money;

        public CarsStatus.CarData[] carDatas { get { return CarDatas; }set { CarDatas = value; } }
        public int money { get { return Money; }set { Money = value; } }
    }

   static public void DataSave()
    {
        var data = new Data()
        {
            carDatas = CarsStatus.cars,
            money = ShopMain.Money
        };
        var json = JsonUtility.ToJson(data);
        var path = $"{ Application.persistentDataPath }\\SaveData.json";
        System.IO.File.WriteAllText(path, json); //保存
    }

   static public void DataLoad()
    {
        var path = $"{ Application.persistentDataPath }\\SaveData.json";
        var json = System.IO.File.ReadAllText(path);
        var data = JsonUtility.FromJson<Data>(json);

        CarsStatus.cars = data.carDatas;
        ShopMain.Money = data.money;

    }
}
