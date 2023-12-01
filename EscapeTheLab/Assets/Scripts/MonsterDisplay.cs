using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterDisplay : MonoBehaviour
{
    public Level1Monster monster1;
    public Slider slider;
    
    
    void Update()
    {
        slider.value = monster1.health;
    }
}
