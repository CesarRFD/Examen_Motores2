using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGatesFunction : MonoBehaviour
{
    [SerializeField] private BoxCollider2D[] gates;
    [SerializeField] private GameRules gameRules;
    private bool stateGate1;
    private bool stateGate2;
    private bool stateGate3;
    // Start is called before the first frame update
    void Start()
    {
        gates[0].enabled = false;
        gates[1].enabled = false;
        gates[2].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        getStateGate1();
        getStateGate2();
        getStateGate3();

        if(stateGate1 == true)
        {
            gates[0].enabled = true;
        }
        if (stateGate2 == true)
        {
            gates[1].enabled = true;
        }
        if (stateGate3 == true)
        {
            gates[2].enabled = true;
        }
    }
    public bool getStateGate1()
    {
        return stateGate1;
    }
    public bool getStateGate2()
    {
        return stateGate2;
    }
    public bool getStateGate3()
    {
        return stateGate3;
    }
}
