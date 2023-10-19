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
        health = 100;
        coins = 0;
        accessCardLevel = 0;
        weaponLevel = 0;
        bloodCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
