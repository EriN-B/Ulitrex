using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreDisplay : MonoBehaviour
{
    public Text HighscoreText;
    // Start is called before the first frame update
    void Start()
    {
        HighscoreText.text = "Highscore : " +  PlayerPrefs.GetInt("Highscore187");
       
    }
    
}
    