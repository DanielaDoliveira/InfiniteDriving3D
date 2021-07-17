using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChanges : MonoBehaviour
{
    // Start is called before the first frame update
  
    // Update is called once per frame
    public string sceneToLoad;

    public float timeToLoad;
    void Start()
    {
        Invoke("LoadScene",timeToLoad);
    }
    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
