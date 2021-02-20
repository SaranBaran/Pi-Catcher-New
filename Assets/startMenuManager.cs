using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startMenuManager : MonoBehaviour
{

    public string scenes;

    public void startScenes()
    {
        SceneManager.LoadScene(scenes);
        Debug.Log("Start");
    }

}
