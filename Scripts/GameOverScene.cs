using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class GameOverScene : MonoBehaviour
{
    public Text coinPoints,recordPoints,recordmessage;
    public int coinNumber, recordNumber;
    public AudioSource carAudioSource;
    public AudioClip carBroke;
    void Start()
    {
        carAudioSource.PlayOneShot(carBroke);
        CheckRecord();
        coinPoints.text = PlayerPrefs.GetInt("COINPOINTS").ToString();
        recordPoints.text = PlayerPrefs.GetInt("RECORDPOINTS").ToString();
        

    }

   
  

    void CheckRecord()
    {
        if (PlayerPrefs.GetInt("COINPOINTS") > PlayerPrefs.GetInt("RECORDPOINTS"))
        {
            recordmessage.text = "You're a new record!";
            coinNumber = PlayerPrefs.GetInt("COINPOINTS");
            PlayerPrefs.SetInt("RECORDPOINTS", coinNumber);
            recordPoints.text = PlayerPrefs.GetInt("RECORDPOINTS").ToString();
        }
        else
        {

            recordmessage.text = "Maximum points: ";
        }
    }
    

   
}
