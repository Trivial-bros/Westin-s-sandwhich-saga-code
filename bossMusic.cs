using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bossMusic : MonoBehaviour
{
    public GameObject MusicObject2;
    public GameObject MusicObject;
    public GameObject BossHeart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(MusicObject);
        MusicObject2.SetActive(true);
        BossHeart.SetActive(true);
    }
}
