using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPause : MonoBehaviour
{
    private bool pauseActive;
    public GameObject pauseMenu;
    public AudioSource backgroundAS;
    public AudioSource playerAS;
    public AudioSource startingGameAS;
    public AudioSource toReadAS;
    public AudioSource intheHouseAS;
    public AudioSource enemy1AS;
    public AudioSource enemy2AS;
    public AudioSource enemy3AS;
    public AudioSource enemy4AS;
    
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
        Player.shootSound = true;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pauseActive = false;
        playerAS.UnPause();
        backgroundAS.UnPause();
        startingGameAS.UnPause();
        //ending game
        toReadAS.UnPause();
        intheHouseAS.UnPause();
        enemy1AS.UnPause();
        enemy2AS.UnPause();
        enemy3AS.UnPause();
        enemy4AS.UnPause();
    }

    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Player.shootSound = false;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pauseActive = true;
        playerAS.Pause();
        backgroundAS.Pause();
        startingGameAS.Pause();
        //ending game
        toReadAS.Pause();
        intheHouseAS.Pause();
        enemy1AS.Pause();
        enemy2AS.Pause();
        enemy3AS.Pause();
        enemy4AS.Pause();
    }
}
