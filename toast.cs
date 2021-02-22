using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toast : MonoBehaviour
{
    public Playermovement playermovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playermovement.speed += 5;
        }
    }
}
