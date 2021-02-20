﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenes : MonoBehaviour
{
    public string nextSceneName;
    public GameObject sceneOne;
    public GameObject sceneTwo;
    public GameObject sceneThree;
    public GameObject sceneFour;


    void Start()
    {
        sceneOne.SetActive(true);
        sceneTwo.SetActive(false);
        sceneThree.SetActive(false);
        sceneFour.SetActive(false);
    }

    public void SceneTwo()
    {
        sceneOne.SetActive(false);
        sceneTwo.SetActive(true);
    }

    public void SceneThree()
    {
        sceneTwo.SetActive(false);
        sceneThree.SetActive(true);
    }

    public void SceneFour()
    {
        sceneThree.SetActive(false);
        sceneFour.SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene(nextSceneName);       
    }

}