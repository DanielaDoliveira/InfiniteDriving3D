using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoins : MonoBehaviour
{
 
    public Transform[] spawns;
    private GameObject newPrefab,newPrefab2;
    public GameObject coinsPrefab;
    private int rand;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeCoins();
    }

    void MakeCoins()
    {
        if (newPrefab == null)
        {
            rand = Random.Range(0, 4);
            newPrefab = Instantiate(coinsPrefab,spawns[rand]) as GameObject;
           
        }
      
        
    }
  
}
