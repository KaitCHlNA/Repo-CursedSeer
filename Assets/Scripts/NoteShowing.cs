using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteShowing : MonoBehaviour
{
    public AudioSource audBackground;
    public AudioSource audSus;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        
        Time.timeScale = 0;
        Player.canShoot = false;
        audBackground.Pause();
        audSus.Pause();
    }

    public void CloseMessage()
    {
        Cursor.lockState = CursorLockMode.None;
        
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
        Player.canShoot = true;
        audBackground.UnPause();
        audSus.UnPause();
    }
}
