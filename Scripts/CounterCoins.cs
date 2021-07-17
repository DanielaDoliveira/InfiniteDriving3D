using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterCoins : MonoBehaviour
{
     CoinsManager _coinsManager;

     private void Start()
     {
         _coinsManager = GameObject.FindWithTag("GameController").GetComponent<CoinsManager>();
     }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            _coinsManager.AddCoins();
            Destroy(gameObject);
        }
    }

     private void OnBecameInvisible()
     {
         Destroy(gameObject);
     }
}
