using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFloor : MonoBehaviour
{
    Delvey delvey;

    void Start()
    {
        delvey = GameObject.Find("Delvey").GetComponent<Delvey>();
    } 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (delvey.accessCardLevel > 0)
        {
            // Change Scene to Fight Level
            SceneManager.LoadScene("MainMenu");

        }
        else
        {
            Debug.Log("Need Access Card 1 or higher");
        }
    }
}
