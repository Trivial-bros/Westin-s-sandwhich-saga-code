using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese : MonoBehaviour
{
    public projectile projectile;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            projectile.damage = projectile.damage += 20;
            projectile.speed = projectile.speed += 10;
        }
    }
}
