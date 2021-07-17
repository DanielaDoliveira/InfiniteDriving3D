using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class GameOverScene : MonoBehaviour
{
    public Text coinPoints,recordPoints,recordmessage,obstaclePoints;
    public int coinNumber, recordNumber;
    void Start()
    {
        coinPoints.text = PlayerPrefs.GetInt("COINPOINTS").ToString();
        recordPoints.text = PlayerPrefs.GetInt("RECORDPOINTS").ToString();
        obstaclePoints.text = PlayerPrefs.GetInt("OBSTACLES").ToString();

    }

   
    void Update()
    {
        CheckRecord();
       
    }

    void CheckRecord()
    {
        if (PlayerPrefs.GetInt("COINPOINTS") > PlayerPrefs.GetInt("RECORDPOINTS"))
        {
            recordmessage.text = "You're a new record!";
            coinNumber = PlayerPrefs.GetInt("COINPOINTS");
            PlayerPrefs.SetInt("RECORDPOINTS", coinNumber);
        }
        else
        {

            recordmessage.text = "Maximum points: ";
        }
    }
    

   
}
