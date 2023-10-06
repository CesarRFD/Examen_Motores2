using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    private float speed = 1;
    [SerializeField] private GameObject player;
    [SerializeField] private EnterGatesFunction enterGatesFunction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enterGatesFunction.GetZone3())
        {
            StartCoroutine(Delay(1.5f));

        }
    }
    IEnumerator Delay(float Tiempo)
    {
        yield return new WaitForSeconds(Tiempo);
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
