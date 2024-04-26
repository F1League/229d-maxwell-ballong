using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<BoxCollider2D>();
        }
        else
        {
            c = GetComponent<Collider2D>();
        }
        c.isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

    void Updade()
    {
        
    }
}
