using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lettuce : MonoBehaviour
{
    public Collectible collectible;
    public Playermovement Playermovement;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Playermovement.extraJumpsValue++;
        }
    }
}
