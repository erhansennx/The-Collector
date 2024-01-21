﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button levelButton;
    [SerializeField] private Button quitButton;
   
    private const string gameScene = "GameScene";

    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(gameScene);
            Time.timeScale = 1f;
            //GameManager.gameManagerInstance.gameState = true;
        });

        //sasa
        levelButton.onClick.AddListener(() => 
        {
            Debug.Log("Level Button");

        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
            Debug.Log("Quit");
        });
    }


 
}
