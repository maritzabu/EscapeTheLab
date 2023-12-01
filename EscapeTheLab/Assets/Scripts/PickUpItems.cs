using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUpItems : MonoBehaviour
{   
    public GameObject gameover;
    public Text text;
    bool isColliding= false;
    public Delvey delvey;
    void Start()
    {
        delvey = GameObject.Find("Delvey").GetComponent<Delvey>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(isColliding) return;
        
        isColliding = true;
        
        if (this.gameObject.layer == 6)
        {
            delvey.coins += 1;
            PlayerPrefs.SetInt("coins", delvey.coins);
        }
        else if (this.gameObject.layer == 7 )
        {
            delvey.weaponLevel += 1;
            PlayerPrefs.SetInt("weaponLevel", delvey.weaponLevel);
        }
        else if (this.gameObject.layer == 8)
        {
            delvey.bloodCount += 1;
            PlayerPrefs.SetInt("bloodCount", delvey.bloodCount);
            GetComponent<AudioSource>().pitch = Random.Range(.9f,1.1f);
            GetComponent<AudioSource>().Play();
            isColliding = false;
            
            if (delvey.bloodCount > 2)
            {
                StartCoroutine(LoadNewScene());
            }

            return;

        }
        else if (this.gameObject.layer == 9)
        {
            delvey.accessCardLevel += 1;
            PlayerPrefs.SetInt("accessCardLevel", delvey.accessCardLevel);
        }
        
        GetComponent<SpriteRenderer>().color = Color.clear;
        GetComponent<AudioSource>().pitch = Random.Range(.9f,1.1f);
        GetComponent<AudioSource>().Play();
        StartCoroutine(Reset());
        
    }


    IEnumerator Reset()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        isColliding = false;
    }

    IEnumerator LoadNewScene()
    {
        int i = 0;
        while (i < 5){
            yield return new WaitForSeconds(1);
            i++;
            delvey.health -= 20; 
            PlayerPrefs.SetInt("health", delvey.health);
        }
        gameover.SetActive(true);
        text.text = "GAME OVER";
        i = 0;

        while (i < 3){
            yield return new WaitForSeconds(1);
            i++;
        }
        SceneManager.LoadScene("MainMenu");
    }
}
