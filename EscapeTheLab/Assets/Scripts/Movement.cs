using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    protected Rigidbody2D rb;
    public Transform body;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   public void MoveRB(Vector3 vel)
   {
          rb.velocity = vel * speed;
          if(vel.x > 0){
            body.localScale = new Vector3(10,10,10);
          }
          else if(vel.x < 0){
            body.localScale = new Vector3(-10,10,10);
            }
   }
   public void MoveToward(Vector3 targetPosition)
   {
        Vector3 direction = targetPosition - transform.position;
        direction = Vector3.Normalize(direction);
        MoveRB(direction);
   }
}
