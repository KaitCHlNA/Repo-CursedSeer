using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public Text textTime;

    void Update()
    {
        textTime.text = "Time: " + Timer.currentTime;
        if (Player.life <= 0)
        {
            Timer.currentTime = 0;
        }
    }
}
