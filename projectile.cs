using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public playerHealth playerHealth;

    private void Start()
    {
        rb.velocity = transform.right * speed;
        Debug.Log("Shot");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyHealth enemy =  collision.GetComponent<enemyHealth>();
        if(enemy != null)
        {
            enemy.takeDamage(damage);
        }
        Destroy(gameObject);
    }

    private void Update()
    {
        if(playerHealth.currentHealth == 0)
        {
            speed = 20f;
            damage = 40;
        }
    }
}
