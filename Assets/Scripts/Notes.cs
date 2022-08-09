using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New note", menuName = "Note")]
public class Notes : ScriptableObject
{
    public string description;
    public Sprite backgroundNote;

}
