using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class credit022 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       SceneManager.LoadScene(4);
    }
}
