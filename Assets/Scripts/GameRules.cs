using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    private GameObject[] enemys1;
    [SerializeField] private int enemysCount1;

    private GameObject[] enemys2;
    [SerializeField] private int enemysCount2;

    private GameObject[] enemys3;
    [SerializeField] private int enemysCount3;

    [SerializeField] private bool stateGate1 = false;
    [SerializeField] private bool stateGate2 = false;
    [SerializeField] private bool stateGate3 = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setStateGate1();
        setStateGate2();
        setStateGate3();
        enemys1 = GameObject.FindGameObjectsWithTag("Enemy1");
        enemysCount1 = enemys1.Length;

        enemys2 = GameObject.FindGameObjectsWithTag("Enemy2");
        enemysCount2 = enemys2.Length;

        enemys3 = GameObject.FindGameObjectsWithTag("Enemy3");
        enemysCount3 = enemys3.Length;

        if (enemysCount1 == 0)
        {
            stateGate1 = true;
        }
        if (enemysCount2 == 0)
        {
            stateGate2 = true;
        }
        if (enemysCount3 == 0)
        {
            stateGate3 = true;
        }
    }
    public bool setStateGate1()
    {
        return stateGate1;
    }
    public bool setStateGate2()
    {
        return stateGate2;
    }
    public bool setStateGate3()
    {
        return stateGate3;
    }
}