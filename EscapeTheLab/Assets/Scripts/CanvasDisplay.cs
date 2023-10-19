using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDisplay : MonoBehaviour
{
    public Delvey delvey;
    public Text coinsText;
    public Slider slider;
    public Text bloodCount;
    public Text weaponLevel;
    public Text cardLevel;

    void Awake()
    {
        //coinsText = GetComponent<Text>();
        //slider = GetComponent<Slider>();
    }
    
    void Update()
    {
        coinsText.text = delvey.coins.ToString();
        slider.value = delvey.health;
        bloodCount.text = "x " + delvey.bloodCount.ToString();
        weaponLevel.text = "Lvl. " + delvey.weaponLevel.ToString();
        cardLevel.text = "Lvl. " + delvey.accessCardLevel.ToString();
    }
}
 