using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coins : MonoBehaviour
{
     public int value;
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            
            
            Counter.instance.IncreaseCoins(value);
        }
    }
}
