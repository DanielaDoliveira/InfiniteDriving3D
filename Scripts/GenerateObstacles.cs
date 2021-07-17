﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public GameObject boxPrefab,conePrefab;
    public Transform[] spawns;
    public Transform[] coinSpawns;
    private GameObject newPrefab,newPrefab2;
    public int timeToCoinSpawn;
   
   
   
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        GenerateBox();
      
      
    }

    void GenerateBox()
    {
        if (newPrefab == null)
        {
            int rand = Random.Range(0,2);

            newPrefab = Instantiate(boxPrefab, spawns[rand]) as GameObject;
            
        }
        Invoke("GenerateBox2",3.0f);
        timeToCoinSpawn = Random.Range(0, 1);
       

    }

    void GenerateBox2()
    {
        if (newPrefab2 == null)
        {
            int rand = Random.Range(0, 2);

            newPrefab2 = Instantiate(conePrefab, spawns[rand]) as GameObject;
           
      
        }
    }


    

   
 
}
