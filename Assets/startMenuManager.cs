using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startMenuManager : MonoBehaviour
{

    public string scenes;
    public GameObject mainCanvas;
    public GameObject creditsCanvas;

    void Start()
    {
        mainCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
    }

    public void startScenes()
    {
        Invoke("sceneLoad",1);
        Debug.Log("Start");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void creditsGo()
    {
        mainCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
    }

    public void back()
    {
        mainCanvas.SetActive(true);
        creditsCanvas.SetActive(false);
    }


    void sceneLoad()
    {
        SceneManager.LoadScene(scenes);
    }

}
