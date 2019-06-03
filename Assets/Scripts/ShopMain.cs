using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMain : MonoBehaviour
{
    public bool[] BoardingPermission { get; set; }
    public enum Cars { NomalCar, SportsCar, Jeep, Bicycle, MotorBicycle, Excavator, Bulldozer }
    public Cars[] cars = new Cars[7] {Cars.NomalCar,Cars.SportsCar,Cars.Jeep,Cars.Bicycle,Cars.MotorBicycle,Cars.Excavator,Cars.Bulldozer };
    [SerializeField]
    private Texture[] CarsTexture = new Texture[7];
    [SerializeField]
    private GameObject Prize;
    // Start is called before the first frame update
    void Start()
    {
        BoardingPermission = new bool[7]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
