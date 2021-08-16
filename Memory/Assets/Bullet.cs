using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed = 4f;
    public float mesafe;
    public float acceleration = 0.3f;
    Rigidbody2D rb;
    private GameObject target;
    Vector2 moveDirection;
    
    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Character");
        rb = GetComponent<Rigidbody2D>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, mesafe);

    }
    private void Update()
    {

        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("colliderler"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
        if (col.gameObject.tag == ("trail"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Player")
        {
            
     
        }
        
    }
   


}