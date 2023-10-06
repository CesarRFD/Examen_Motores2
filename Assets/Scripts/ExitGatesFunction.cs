using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGatesFunction : MonoBehaviour
{
    [SerializeField] private BoxCollider2D[] gates;
    [SerializeField] private GameRules gameRules;
    [SerializeField] private SpriteRenderer backGround;

    private bool stateGate1;
    private bool stateGate2;
    private bool stateGate3;
    // Start is called before the first frame update
    void Start()
    {
        gates[0].enabled = false;
        gates[1].enabled = false;
        gates[2].enabled = false;
        gates[3].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameRules.setStateGate1())
        {
            gates[0].enabled = true;
        }
        if (gameRules.setStateGate2())
        {
            gates[1].enabled = true;
        }
        if (gameRules.setStateGate3())
        {
            gates[2].enabled = true;
        }

        if (gameRules.setFinalGate())
        {
            gates[3].enabled = true;
            backGround.enabled = true;
        }
    }
}
