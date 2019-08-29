using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CarsStatus : MonoBehaviour
{
    [Serializable]
    public class CarData
    {
        public string Name;
        public float Speed;
        public int JumpNum;
        public bool GetFlag;
        public float Distance;

        public CarData(string name, float speed, int jumpNum, bool getFlag, float distance)
        {
            Name = name;
            Speed = speed;
            JumpNum = jumpNum;
            GetFlag = getFlag;
            Distance = distance;
        }

    }

    public static CarData[] cars = new CarData[10];
    public static bool New;
    public void Awake()
    {
        if (New == false)
        {
            cars = new CarData[7];
            cars[0] = new CarData("NomalCar", 1, 1, true, 0);
            cars[1] = new CarData("SportsCar", 2, 1, false, 0);
            cars[2] = new CarData("Jeep", 2, 2, false, 0);
            cars[3] = new CarData("Bicycle", 1, 3, true, 0);
            cars[4] = new CarData("MotorBicycle", 2, 3, false, 0);
            cars[5] = new CarData("Excavator", 2, 2, false, 0);
            cars[6] = new CarData("Bulldozer", 2, 1, false, 0);
            if (System.IO.File.Exists($"{ Application.persistentDataPath }\\SaveData.json") == true)
                SaveData.DataLoad();
            New = true;
        }
        for (int i = 0; i < 7; i++)
            Debug.Log($"{cars[i].Name} {cars[i].GetFlag}");
    }

}
