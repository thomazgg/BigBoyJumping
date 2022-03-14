using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float fallingTime = .5f;

    private TargetJoint2D target;
    private BoxCollider2D coll;

    // Start is called before the first frame update
    private void Start()
    {
        target = GetComponent<TargetJoint2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {   
            Invoke("Falling", fallingTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Destroy")
        {   
            Destroy(gameObject);
        }
    }

    private void Falling()
    {
        target.enabled = false;
        coll.isTrigger = true;
    }
}
