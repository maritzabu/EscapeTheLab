using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Movement movement; 
    public GameObject swordobject;
    public GameObject bloodObject;
    public Delvey delvey;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        
        if(Input.GetKey(KeyCode.W)){
            vel.y = 1;
        }
        if(Input.GetKey(KeyCode.S)){
            vel.y = -1;
        }
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }
        if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        if(Input.GetKey(KeyCode.Alpha1)){

            if (delvey.weaponLevel > 0)
            {
                swordobject.SetActive(true);
                bloodObject.SetActive(false);
                
            }
        }
        else if(Input.GetKey(KeyCode.Alpha2)){
            if (delvey.bloodCount > 0)
            {
                
                bloodObject.SetActive(true);
                swordobject.SetActive(false);
        
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (bloodObject.activeSelf)
            {
                delvey.health += 25;
                if (delvey.health > 100)
                    delvey.health = 100;
                PlayerPrefs.SetInt("health", delvey.health);
                delvey.bloodCount--;
                PlayerPrefs.SetInt("bloodCount", delvey.bloodCount);
                if (delvey.bloodCount == 0)
                    bloodObject.SetActive(false);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            
            //if blood object active increase delvey hp by 25
            //if swordObjectActive change animation to slicing
            //for sword transform where it x+ y- position rotate z- 
            if (swordobject.activeSelf)
            {
                swordobject.transform.Rotate(new Vector3(0,0,300) * Time.deltaTime);
            }

        }
       

        movement.MoveRB(vel);
    }
}
