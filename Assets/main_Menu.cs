using UnityEngine.SceneManagement;
using UnityEngine;


public class main_Menu : MonoBehaviour
{
   public void PlayGame()
   {
      SceneManager.LoadScene(1);
   }

   public void LoadWorlds()
   {
      SceneManager.LoadScene(3);
   }
}
