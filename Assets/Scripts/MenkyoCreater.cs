using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenkyoCreater : MonoBehaviour
{
    [SerializeField]
    PlayerController playerInstance;

    [SerializeField] GameObject _menkyo;

    [SerializeField, Header("Pop Timing")]
    float popTiming;
    [SerializeField]
    float randomDeviationWidth; //ポップタイミングのランダムずらしの差分MAX

    [SerializeField]
    Sprite[] sprites;

    private float _timer;
    List<int> originIndex;

    void Start()
    {
        _timer = popTiming + Random.Range(-randomDeviationWidth, randomDeviationWidth);
        originIndex = new List<int>();
        for (int i = 0; i < CarsStatus.cars.Length; i++)
        {
            if (CarsStatus.cars[i].GetFlag)
            {
                originIndex.Add(i);
            }
        }
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0.0f)
        {
            _timer += popTiming + Random.Range(-randomDeviationWidth, randomDeviationWidth);
            var obj = GameObject.Instantiate(_menkyo);
            obj.transform.position = transform.position;
            int rand = Random.Range(0, originIndex.Count);
            if (originIndex[rand] == playerInstance.vehicleIndex) rand = (rand + 1) % originIndex.Count;
            obj.GetComponent<Item>().Create(originIndex[rand], sprites[originIndex[rand]]); //Car count
        }
    }
}
