using System.Collections;
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

    public void GameOver()
    {
        Debug.Log("you dead...");

        //スコア計算

        SceneManager.LoadScene(0);
    }
}
