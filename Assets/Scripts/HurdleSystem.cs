using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleSystem : MonoBehaviour
{
    [SerializeField] Hurdle[] hurdleTypes;

    [SerializeField, Header("Pop Timing")]
    float popTiming;
    [SerializeField]
    float randomDeviationWidth; //ポップタイミングのランダムずらしの差分MAX

    private float _timer;

    void Start()
    {
        _timer = popTiming + Random.Range(-randomDeviationWidth, randomDeviationWidth);
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer < 0.0f)
        {
            _timer += popTiming + Random.Range(-randomDeviationWidth, randomDeviationWidth);
            var obj = GameObject.Instantiate(hurdleTypes[0]);
            obj.transform.position = transform.position;
        }
    }
}
