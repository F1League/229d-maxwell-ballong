using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLR : MonoBehaviour
{
    float dirX, moveSpeed = 4f;

    private bool moveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -10.34f)
            moveRight = false;
        if (transform.position.x < -4.85f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

    }
}
