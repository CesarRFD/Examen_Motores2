using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGatesFunction : MonoBehaviour
{
    [SerializeField] private Camera cam;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnterGate1")
        {
            cam.transform.position = new Vector3(-21, 0, -10);
            this.transform.position = new Vector3(-14, 0, 0);
        }
        if (collision.gameObject.tag == "EnterGate2")
        {
            cam.transform.position = new Vector3(0, -13, -10);
            this.transform.position = new Vector3(0, -10.5f, 0);
        }
        if (collision.gameObject.tag == "EnterGate3")
        {
            cam.transform.position = new Vector3(21, 0, -10);
            this.transform.position = new Vector3(14, 0, 0);
        }
        if (collision.gameObject.tag == "ExitGate")
        {
            cam.transform.position = new Vector3(0, 0, -10);
            this.transform.position = new Vector3(0, 0, 0);
        }
        if (collision.gameObject.tag == "FinalGate")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}