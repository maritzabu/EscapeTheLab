using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpItems : MonoBehaviour
{
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
        }
        else if (this.gameObject.layer == 7 )
        {
            delvey.weaponLevel += 1;
        }
        else if (this.gameObject.layer == 8)
        {
            delvey.bloodCount += 1;
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
        }
        
        GetComponent<SpriteRenderer>().color = Color.clear;
        GetComponent<AudioSource>().pitch = Random.Range(.9f,1.1f);
        GetComponent<AudioSource>().Play();
        StartCoroutine(Reset());
        
    }


    IEnumerator Reset()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(3);
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
        }
        
        SceneManager.LoadScene("MainMenu");
    }
}
