using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PoisonGasAttack : MonoBehaviour
{
    public Delvey delvey;
    public GameObject gameover;
    public Text text;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 12)
        {
            delvey.health -= 5;
            PlayerPrefs.SetInt("health", delvey.health);
            if(delvey.health <= 0)
            {
                StartCoroutine(LoadNewScene());
            }
        }
     }

     IEnumerator LoadNewScene()
    {
        gameover.SetActive(true);
        text.text = "GAME OVER";
        int i = 0;
        while (i < 3){
            yield return new WaitForSeconds(1);
            i++;
        }
        SceneManager.LoadScene("MainMenu");
    }
}
