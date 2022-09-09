using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPause : MonoBehaviour
{
    private bool pauseActive;
    public GameObject pauseMenu;
    public AudioSource backgroundAS;
    public AudioSource toReadAS;
    public AudioSource intheHouseAS;
    

    void Update()
    {
        TogglePause();
    }

    void TogglePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive) {ResumeGame();}
            else {PauseGame();}
        }
    }

    void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pauseActive = false;
        Player.canShoot = true;
        backgroundAS.UnPause();
        toReadAS.UnPause();
        intheHouseAS.UnPause();
        
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        Player.canShoot = false;
        pauseActive = true;
        backgroundAS.Pause();
        toReadAS.Pause();
        intheHouseAS.Pause();
    }
}
