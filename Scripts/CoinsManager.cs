using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    private int coinsCounter = 0;
    public Text coinsText;
    void Start()
    {
        
    }

    public void AddCoins()
    {
        coinsCounter += 1;
        PlayerPrefs.SetInt("COINPOINTS",coinsCounter);
        coinsText.text = PlayerPrefs.GetInt("COINPOINTS").ToString();
    }
}
