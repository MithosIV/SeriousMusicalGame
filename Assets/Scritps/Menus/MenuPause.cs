using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject menuPause;
    [SerializeField] private GameObject menuGameOver;
    [SerializeField] private GameObject menuWin;

    private void GameOverActivate(object sender, EventArgs e)
    {
        Time.timeScale = 1f;
        menuGameOver.SetActive(true);
    }
    private void WinActivate(object sender, EventArgs e)
    {
        Debug.Log("WinActivate");
        Time.timeScale = 1f;
        menuWin.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
    
    }
