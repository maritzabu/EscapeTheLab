using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delvey : MonoBehaviour
{
    public int health;
    public int coins;
    public int accessCardLevel;
    public int weaponLevel;
    public int bloodCount;
    // Start is called before the first frame update
    void Start()
    {
        health = PlayerPrefs.GetInt("health");
        coins = PlayerPrefs.GetInt("coins");
        accessCardLevel = PlayerPrefs.GetInt("accessCardLevel");
        weaponLevel = PlayerPrefs.GetInt("weaponLevel");
        bloodCount = PlayerPrefs.GetInt("bloodCount");
        //int[] xpositions = {100, -14, 83, 160};
        //int[] ypositions = {-104, -1, 117, 63};
        //int randInt = Random.Range(0,4);
        //transform.position = new Vector3(xpositions[randInt], ypositions[randInt], 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
