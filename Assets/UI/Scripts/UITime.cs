using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public Text textTime;

    void Update()
    {
        textTime.text = "Time: " + Mathf.Round(Timer.timeInEntireGame);
        if (Player.life <= 0)
        {
            Timer.timeInEntireGame = 0;
        }
    }
}
