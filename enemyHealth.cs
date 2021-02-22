using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public ParticleSystem deatheffect;
    public TextMeshProUGUI enemyHPText;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void FixedUpdate()
    {
        if (enemyHPText != null)
        {
            enemyHPText.text = currentHealth + "";
        }

    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            deatheffect.Play();
            Invoke("Die", 0.2f);
        }
    }
        
    void Die()
    {
        deatheffect.Play();
        Destroy(gameObject);
    }
}
