using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPauseOption : MonoBehaviour
{
    public GameObject backMenuOption;

    public void BackToMenu()
    {
        backMenuOption.SetActive(true);
    }
    
    public void ClickOnYes()
    {
        Application.Quit();
    }
    
    public void ClickOnNo()
    {
        backMenuOption.SetActive(false);
    }
}
