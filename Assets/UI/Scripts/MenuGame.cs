using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuGame : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadScene(1);
   }
   
   //VOID PARA LAS OPCIONES

   public void ExitGame()
   {
      Application.Quit();
   }
}
