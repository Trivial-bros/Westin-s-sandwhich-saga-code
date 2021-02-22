using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public TextMeshProUGUI textMesh;
    public Audio_Manager Audio_Manager;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        textMesh.text = currentHealth + "";

       

        if(currentHealth <= 0)
        {
            currentHealth = 0;

        }

        if(currentHealth > 100)
        {
            currentHealth = maxHealth;
        }
    }

    public void takeDamage(int damage)
    {
        Audio_Manager.Play("PlayerDeath");
        currentHealth -= damage;
    }
}
