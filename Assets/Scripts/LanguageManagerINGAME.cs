using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManagerINGAME : MonoBehaviour
{
    public int ChangeLanguage = 0;
    public string[] EnTexts;
    public string[] EspTexts;
    public Text[] texts;

    void Update()
    {
        if (ChangeLanguage == 0)
        {
            ENlanguage();
        }
        else if (ChangeLanguage == 1)
        {
            ESPlanguage();
        }
    }

    public void ChangingLanguage()
    {
        if (ChangeLanguage == 0)
        {
            ChangeLanguage = 1;
        } else if (ChangeLanguage == 1)
        {
            ChangeLanguage = 0;
        }
        
    }

    void ENlanguage()
    {
        for (int i = 0; i < texts.Length; i++)
        { 
            if(texts[i] != null) 
            { 
                texts[i].text = EnTexts[i]; 
            }
        }
    }

    void ESPlanguage()
    {
        for (int i = 0; i < texts.Length; i++)
        { 
            if(texts[i] != null) 
            { 
                texts[i].text = EspTexts[i]; 
            }
        }
    }
}
