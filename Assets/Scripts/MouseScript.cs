using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    public void MouseActive()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void MouseDissable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
