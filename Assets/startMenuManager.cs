using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startMenuManager : MonoBehaviour
{

    public string scenes;


    public void startScenes()
    {
        Invoke("sceneLoad",1);
        Debug.Log("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }

    void sceneLoad()
    {
        SceneManager.LoadScene(scenes);
    }

}
