using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<Collider2D>();
        }
        else 
        {
            c = GetComponent<Collider2D>();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
            GameManager1.nScore ++;
            ScoreText.text = "Score : " + GameManager1.nScore ;
            Destroy(gameObject);


    }
}
