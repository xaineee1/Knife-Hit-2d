using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    [SerializeField]
    private GameObject knife;

    private bool canFireKnife;
    private bool touchTheTarget;

    [SerializeField]
    private float speedForce;

    private Rigidbody2D rb;

    private void Awake()
    {
        Initialize();
        FireTheKnife();
    }

    public void Initialize()
    {
        knife.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(canFireKnife)
        {
            rb.velocity = new Vector2(0, speedForce);
        }
    }

    public void FireTheKnife()
    {
        knife.SetActive(true);
        rb.isKinematic = false;
        canFireKnife = true;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (touchTheTarget)
            return;

        if(target.tag == "Enemy")
        {
            canFireKnife = false;
            touchTheTarget = true;

            rb.isKinematic = true;
            gameObject.transform.SetParent(target.transform);
        }
    }
}
