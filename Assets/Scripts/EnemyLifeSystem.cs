using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeSystem : MonoBehaviour
{
    [SerializeField] private GameObject gg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destruye el objeto del jugador
            Destroy(collision.gameObject);
            gg.SetActive(true);
        }
    }
}
