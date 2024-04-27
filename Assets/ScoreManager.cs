using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private  void onTriggerEnter2D(Collider2D other)
{
    if(other.tag == "Item")
    {
        score++;
        ScoreText.text = "Score = " + score;
        Destroy(other.gameObject);
    }
}

}
