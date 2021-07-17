using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
     float speed = 15f; 
     float turnSpeed = 8.0f;
     float forwardInput,horizontalInput;
  
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      MovePlayer();
     
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            
            SceneManager.LoadScene("GameOver");
        }
    }

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // forwardInput = Input.GetAxis("Vertical");
        // transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Translate(Vector3.left*Time.deltaTime*speed*horizontalInput);
        transform.Rotate(Vector3.up ,turnSpeed*horizontalInput*Time.deltaTime);
        
    }
    
}
