using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{

    private float speedRotate = 160f;
    float speed = 65f;


    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
       transform.Translate(Vector3.back*speed*Time.deltaTime);
    }
}
