using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystemPlayer : MonoBehaviour
{
    [SerializeField] private GameObject gg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy1"/* || collision.gameObject.tag == "Enemy2" || collision.gameObject.tag == "Enemy3"*/)
        {
            gg.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
