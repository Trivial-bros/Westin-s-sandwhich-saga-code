using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomato : MonoBehaviour
{
    public Collectible collectible;
    public playerHealth playerHealth;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerHealth.currentHealth += 40;
        }
    }
}

