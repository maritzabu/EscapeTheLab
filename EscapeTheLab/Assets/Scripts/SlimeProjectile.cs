using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeProjectile : MonoBehaviour
{
     public GameObject projectilePrefab;
    [SerializeField] float speed = 5f;

    public void Throw(Vector3 targetPosition)
    {
        Rigidbody2D newProjectileRB = Instantiate(projectilePrefab, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
        targetPosition.z = 0;
        Vector3 direction = (targetPosition - transform.position).normalized;
        newProjectileRB.velocity = direction * speed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("sliome");
        Debug.Log(other.gameObject.layer);
        if (other.gameObject.layer == 11)
        {
            Destroy(this.gameObject);
        }
        
     }
}
