using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu_Loader : MonoBehaviour
{
    public int Menu;
    public GameObject Menu187;
    
    public void LevelLoader()
    {
        SceneManager.LoadScene(Menu);
        Time.timeScale = 1f;
    }

    public void Resume()
    {
        Menu187.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}