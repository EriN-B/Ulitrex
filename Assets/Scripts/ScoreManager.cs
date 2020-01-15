using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI text;

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {

    }


    public void ChangeScore(int CoinValue)
    {
        score += CoinValue;
        text.text = "Punkte : " + score.ToString();
        if (PlayerPrefs.GetInt("Highscore187") < score)
        {
            PlayerPrefs.SetInt("Highscore187" , score);
            Debug.Log("Es wurde ein neuer Highscore gesetzt");
            //Debug.Log(score);
        }
        
    }

  
    
    
}
