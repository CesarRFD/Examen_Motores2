using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private GameObject targetObject1;
    [SerializeField] private Movement movement;
    [SerializeField] private SpriteRenderer swordSprite;
    [SerializeField] private BoxCollider2D swordCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(Attack(.1f));
        }

        if (movement.SetHorizontal() > 0)
        {
            targetObject1.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (movement.SetHorizontal() < 0)
        {
            targetObject1.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        if (movement.SetVertical() > 0)
        {
            targetObject1.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        if (movement.SetVertical() < 0)
        {
            targetObject1.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        }

        Vector3 targetPosition = targetObject.transform.position;
        transform.position = targetPosition;

        IEnumerator Attack(float Tiempo)
        {
            swordCollider.enabled = true;
            swordSprite.enabled = true;
            yield return new WaitForSeconds(Tiempo);
            swordCollider.enabled = false;
            swordSprite.enabled = false;
        }
    }
}
