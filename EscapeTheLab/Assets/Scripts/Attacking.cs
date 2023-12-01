using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Attacking : MonoBehaviour
{
    public Level1Monster monster1;
    public GameObject gameover;
    public Text text;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            monster1.health -= 15;
            if(monster1.health <= 0)
            {
                StartCoroutine(LoadNewScene());
            }
        }
     }

     IEnumerator LoadNewScene()
    {
        gameover.SetActive(true);
        text.text = "YOU WIN!";
        int i = 0;
        while (i < 3){
            yield return new WaitForSeconds(1);
            i++;
        }
        
        SceneManager.LoadScene("MainMenu");
    }
}
