using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private GameObject resultPannel;
    [SerializeField] private Text amountText;
    [Serializable]
    public class ResultWindow
    {
        public ResultWindow() { }
        public void SetResultWindow(GameObject pannel, Text text)
        {
            resultPannel = pannel;
            amountText = text;
        }
        private GameObject resultPannel;
        private Text amountText;
        public void ShowResult(string str)
        {
            resultPannel.SetActive(true);
            amountText.text = str.ToString();
        }
        public void ShowResult(float amount) { ShowResult(amount.ToString()); }
    }
    static public ResultWindow resultWindow = new ResultWindow();

    void Start()
    {
        resultWindow.SetResultWindow(resultPannel, amountText);
        resultPannel.SetActive(false);
    }
}
