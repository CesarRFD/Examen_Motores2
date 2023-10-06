using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] private float speed = 3;
    [SerializeField] private GameObject sword;
    [SerializeField] private SpriteRenderer swordSprite;
    [SerializeField] private BoxCollider2D swordCollider;

    float newPosX = 0f;
    float newPosY = 0f;

    private void Awake()
    {

    }

    void Start()
    {
        //anim = GetComponent<Animator>();
        //sword = GameObject.Find("Sword");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(Attack(.1f));
        }

        GameObject targetObject = GameObject.FindWithTag("Sword");

        Transform playerPos = GameObject.Find("Player").transform;
        Transform swordPos = GameObject.Find("Sword").transform;
        Vector3 relativePosition = playerPos.InverseTransformPoint(swordPos.position);

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        transform.Translate(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);

       if (horizontal>0)
        {
            Debug.Log("derecha");
            anim.SetFloat("IdleX", 1f);
            anim.SetFloat("IdleY", 0f);
            newPosX = 1f;
            newPosY = -0.15f;
            swordPos.localPosition = new Vector3(newPosX, newPosY, relativePosition.z);
            targetObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        if (horizontal < 0)
        {
            Debug.Log("izquierda");
            anim.SetFloat("IdleX", -1f);
            anim.SetFloat("IdleY", 0f);
            newPosX = -1f;
            newPosY = -0.15f;
            swordPos.localPosition = new Vector3(newPosX, newPosY, relativePosition.z);
            targetObject.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        if (vertical > 0)
        {
            Debug.Log("arriba");
            anim.SetFloat("IdleX", 0f);
            anim.SetFloat("IdleY", 1f);
            newPosX = 0f;
            newPosY = .8f;
            swordPos.localPosition = new Vector3(newPosX, newPosY, relativePosition.z);
            targetObject.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        if (vertical < 0)
        {
            Debug.Log("abajo");
            anim.SetFloat("IdleX", 0f);
            anim.SetFloat("IdleY", -1f);
            newPosX = 0f;
            newPosY = -0.8f;
            swordPos.localPosition = new Vector3(newPosX, newPosY, relativePosition.z);
            targetObject.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }

    }
    IEnumerator Attack(float Tiempo)
    {
        swordCollider.enabled = true;
        swordSprite.enabled = true;
        yield return new WaitForSeconds(Tiempo);
        swordCollider.enabled= false;
        swordSprite.enabled= false;
    }
}
