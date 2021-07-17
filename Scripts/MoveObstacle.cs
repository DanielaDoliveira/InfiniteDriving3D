using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    // Start is called before the first frame update
     float speed;


    void Start()
    {
        speed = 65f;
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();
    }
    void MoveBox()
    {
       transform.Translate(Vector3.back*speed*Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
     
        Destroy(gameObject);
       
        
    }
}
