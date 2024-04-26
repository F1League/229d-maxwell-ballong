using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static Counter instance;
    public TMP_Text ScoreText;
    public int currentCoins=0;

    void Awake()
    {
        instance = this;
    }
  

    
    void Start()
    {
        ScoreText.text = "Score: " + currentCoins.ToString ();
    }
    public void IncreaseCoins(int V)
    {
        currentCoins += V; 
        ScoreText.text = "Score: " + currentCoins.ToString() ;

    }

}
