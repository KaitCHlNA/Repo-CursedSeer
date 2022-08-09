using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NotesDisplay : MonoBehaviour
{
    public Notes _notes;
    public Text descripText;
    public Image imageNote;

    public GameObject displayMessage;
    void Update()
    {
        ShowMessage();
        ToggleNotes();
    }

    void ShowMessage()
    {
        if (Input.GetKey(KeyCode.E))
        {
            displayMessage.SetActive(true);
        }
    }

    void ToggleNotes()
    {
        descripText.text = _notes.description;
        imageNote.sprite = _notes.backgroundNote;
    }

    public void CloseMessage()
    {
        displayMessage.SetActive(false);
    }
}
