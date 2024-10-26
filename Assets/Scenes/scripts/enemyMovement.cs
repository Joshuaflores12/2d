using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyMovement : MonoBehaviour
{
    private float mvspeed = 5f;
    private Transform player;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) 
        {
         Vector2 direction = (player.position - transform.position).normalized;
        rb.velocity = direction * mvspeed;
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon")) 
        {
            
            Destroy(gameObject);
            Debug.Log("Hit!");
        }
    }   
}
