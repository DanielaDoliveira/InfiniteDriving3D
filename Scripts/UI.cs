using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   
   public void LoadGame()
   {
      SceneManager.LoadScene("Prototype 1");
   }

   public void QuitGame()
   {
      Application.Quit();
   }
}
