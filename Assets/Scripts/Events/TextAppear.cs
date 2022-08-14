using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    public GameObject textAppearObject;
    void Start()
    {
        Events.testEvent += LookBehindText;
    }
    
    void LookBehindText()
    {
        textAppearObject.SetActive(true);
        print("A text appeared - " + this);
    }

    void OnDisable()
    {
        Events.testEvent -= LookBehindText;
        print(this);
    }
}
