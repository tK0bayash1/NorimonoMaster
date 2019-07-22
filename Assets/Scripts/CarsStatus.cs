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

        public CarData(string name, float speed, int jumpNum, bool getFlag)
        {
            Name = name;
            Speed = speed;
            JumpNum = jumpNum;
            GetFlag = getFlag;
        }
     
    }

    public static CarData[] cars = new CarData[10];
    public CarData[] carData = new CarData[10];
    public bool AcceptanceFlag;
    public bool UpdataFlag;
    public void Awake()
    {
        if (CarsStatus.cars[0] != null)
        {
            AcceptanceCars();
        }
        if (UpdataFlag)
            UpdateCars();
        if (AcceptanceFlag)
            AcceptanceCars();
    }
    public void UpdateCars()
    {
        for (int i = 0; i < 7; i++)
        {
           CarsStatus.cars[i] = carData[i];
        }
    }
    public void AcceptanceCars()
    {
        for (int i = 0; i < 7; i++)
        {
            carData[i] = CarsStatus.cars[i];
        }
    }
}
