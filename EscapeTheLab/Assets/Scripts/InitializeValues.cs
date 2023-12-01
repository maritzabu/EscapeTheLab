using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeValues : MonoBehaviour
{
    
    public void initializeValues()
    {
        PlayerPrefs.SetInt("health", 100);
        PlayerPrefs.SetInt("coins", 0);
        PlayerPrefs.SetInt("accessCardLevel", 0);
        PlayerPrefs.SetInt("weaponLevel", 0);
        PlayerPrefs.SetInt("bloodCount", 0);
    }

    
}
