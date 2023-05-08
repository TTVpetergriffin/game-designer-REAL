using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinkGPT : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    public bool danger;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        danger = false;
    }

    void FixedUpdate()
    {
        if (danger == true)
        {
            // Calculate direction away from player
            Vector3 direction = transform.position - player.position;
            direction.Normalize();

            // Apply velocity in opposite direction
            rb.velocity = direction * speed;

            // Maintain gravity and collision
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.name == "dangerzone")
        {
            danger = true;
        }
    }
}
