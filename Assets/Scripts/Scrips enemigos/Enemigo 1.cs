using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 3;
    [SerializeField] private GameObject player;
    [SerializeField] private EnterGatesFunction enterGatesFunction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enterGatesFunction.GetZone1())
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
