using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UILife : MonoBehaviour
{
    public Image lifeBar;
    float currentLife;
    float maxLife;

    void Update()
    {
        currentLife = Player.life;
        lifeBar.fillAmount = currentLife / maxLife;
    }
}
