using UnityEngine;
using UnityEngine.UI;

public class UILife : MonoBehaviour
{
    public Image lifeBar;
    float currentLife;
    float maxLife = 100f;

    void Update()
    {
        currentLife = Player.life;
        lifeBar.fillAmount = currentLife / maxLife;
/*
        if (Player.life <= 0)
        {
            Player.life = 100;
        }*/
    }
}
