using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   public AudioSource audio;
   public AudioClip clip, exit;

   public void LoadGame()
   {
      audio.PlayOneShot(clip);
      Invoke("LoadIntroScene", 2f);
   }

   public void QuitGame()
   {
      audio.PlayOneShot(exit);
      Invoke("ExitGame", 3f);
   }

   public void LoadIntroScene()
   {
      SceneManager.LoadScene("Prototype 1");
   }

   public void ExitGame()
   {
      Application.Quit();
   }
}
