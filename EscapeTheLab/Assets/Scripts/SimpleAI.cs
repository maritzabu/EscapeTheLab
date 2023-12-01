using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    Movement movement;
    [SerializeField] float viewRadius = 5;
    [SerializeField] bool activated = false;
    [SerializeField] Transform playerTransform;
    Vector3 patrolPos = Vector3.zero;

    void Awake()
    {
        movement = GetComponent<Movement>();
    }

    void Update()
    { 
        
        if(Vector3.Distance(transform.position, playerTransform.position) < viewRadius)        
        {
            FollowPlayer();
        }
        else if(activated)
        {
            Patrol();
        }
        else
        {
            Idle();
        }
    }

    public void FollowPlayer()
    {
        activated = true;
        movement.MoveToward(playerTransform.position);
    }

    
    public void Patrol()
    {
        
        if(Vector3.Distance(transform.position,patrolPos) < 10)
        {
            patrolPos = transform.position + new Vector3(Random.Range(-5, 5), Random.Range(-5,5), 0);
        }
    }

    public void Idle()
    {
        movement.MoveRB(Vector3.zero);
    }

}
