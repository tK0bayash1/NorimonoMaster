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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCars()
    {
        for (int i = 0; i < 10; i++)
        {
           CarsStatus.cars[i] = carData[i];
        }
    }
}
