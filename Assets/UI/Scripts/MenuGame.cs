using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuGame : MonoBehaviour
{
   public void PlayGame()
   {
      Invoke("ChangeScene", 1f);
   }
   
   //VOID PARA LAS OPCIONES

   public void ExitGame()
   {
      Application.Quit();
   }

   private void ChangeScene()
   {
      SceneManager.LoadScene(1);
   }
}


