using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    public playerHealth playerHealth;
    public Transform player;
    public Rigidbody2D rb;
    public float attackrange;
    public Animator enemyAnimator;
    private float time = 0.0f;
    public float interpolationPeriod = 5f;

    

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= interpolationPeriod)
        {
            time = 0.0f;

            if (Vector2.Distance(player.position, rb.position) <= attackrange)
            {
                Debug.Log("Close");
                playerHealth.takeDamage(30);
                enemyAnimator.SetTrigger("Attack");
            }
        }
        
    }
}


