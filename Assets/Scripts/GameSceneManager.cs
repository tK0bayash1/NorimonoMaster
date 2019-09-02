﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager instance;
    public static PlayerController player;
    [SerializeField] PlayerController _playerObj;
    void Awake()
    {
        instance = this;
        player = _playerObj;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnClickButton(0);
        }
    }

    public void GameOver()
    {
        Debug.Log("you dead...");

        //スコア計算

        SceneManager.LoadScene(0);
    }

    public void OnClickButton(int num) { SceneManager.LoadScene(num); }
}
