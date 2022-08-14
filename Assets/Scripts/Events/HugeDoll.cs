using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HugeDoll : MonoBehaviour
{
    void Start()
    {
        Events.testEvent += BeingHuge;
        
    }

    void BeingHuge()
    {
        transform.localScale = new Vector3(1, 1, 1);
        print("An Object increase its size - " + this);
    }

    void OnDisable()
    {
        Events.testEvent -= BeingHuge;
        print(this);
    }
}
