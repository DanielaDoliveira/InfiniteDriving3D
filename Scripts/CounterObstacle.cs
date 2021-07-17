using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterObstacle : MonoBehaviour
{
    // Start is called before the first frame update

    private int obsCounter = 0;
    public GameObject[] obstacles;
    public Text obstaclesAvoidedtxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void addObsCounter()
    {
        obsCounter += 1;
        PlayerPrefs.SetInt("OBSTACLES",obsCounter);
        obstaclesAvoidedtxt.text = PlayerPrefs.GetInt("OBSTACLES").ToString();
    }
}
