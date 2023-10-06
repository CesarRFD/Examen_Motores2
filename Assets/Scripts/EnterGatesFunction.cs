using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGatesFunction : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private bool zone1=false;
    private bool zone2 = false;
    private bool zone3 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnterGate1")
        {
            cam.transform.position = new Vector3(-21, 0, -10);
            this.transform.position = new Vector3(-12.56f, 0, 0);
            zone1 = true;
        }
        if (collision.gameObject.tag == "EnterGate2")
        {
            cam.transform.position = new Vector3(0, -13, -10);
            this.transform.position = new Vector3(0, -8.55f, 0);
            zone2 = true;
        }
        if (collision.gameObject.tag == "EnterGate3")
        {
            cam.transform.position = new Vector3(21, 0, -10);
            this.transform.position = new Vector3(12.52f, 0, 0);
            zone3 = true;
        }
        if (collision.gameObject.tag == "ExitGate")
        {
            cam.transform.position = new Vector3(0, 0, -10);
            this.transform.position = new Vector3(-8f, 0, 0);
        }
        if (collision.gameObject.tag == "ExitGate2")
        {
            cam.transform.position = new Vector3(0, 0, -10);
            this.transform.position = new Vector3(0, -2.75f, 0);
        }
        if (collision.gameObject.tag == "ExitGate3")
        {
            cam.transform.position = new Vector3(0, 0, -10);
            this.transform.position = new Vector3(8f, 0, 0);
        }
        if (collision.gameObject.tag == "FinalGate")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public bool GetZone1()
    {
        return zone1;
    }
    public bool GetZone2()
    {
        return zone2;
    }
    public bool GetZone3()
    {
        return zone3;
    }
}

