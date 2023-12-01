using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject instructionsCanvas;

    void Awake()
    {
        //PointsText.points = 0;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void QuitGame()
    {
        Application.Quit();// this does not work in editor
    }

    public void Instructions()
    {
        instructionsCanvas.SetActive(true);
    }
    public void closeInstructions()
    {
        instructionsCanvas.SetActive(false);
    }
}
