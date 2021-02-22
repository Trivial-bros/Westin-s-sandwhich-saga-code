using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    public static int collectibleCount;
    public TextMeshProUGUI collectibleCountText;
    public ParticleSystem pickupeffect;
    public CinemachineShake CinemachineShake;
    public playerHealth playerHealth;
    public Audio_Manager Audio_Manager;
    public bool pickedUp = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        pickedUp = true;
        pickupeffect.Play();
        CinemachineShake.Instance.ShakeCamera(5f, .1f);
        Audio_Manager.Play("PickUpComponent");

        collectibleCount++;
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        if(playerHealth.currentHealth == 0)
        {
            collectibleCount = 0;
        }
        if (collectibleCount <= 9)
        {
            collectibleCountText.text = "X 0" + collectibleCount;
        }
        else
        {
            collectibleCountText.text = "X " + collectibleCount;
        }

    }
}

    
