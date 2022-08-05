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
        SceneManager.LoadScene(0);
    }
    
    public void ClickOnNo()
    {
        backMenuOption.SetActive(false);
    }
}
