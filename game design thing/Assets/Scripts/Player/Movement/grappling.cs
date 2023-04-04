using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class grappling : MonoBehaviour
{
    public Transform targetObject;
    public float moveSpeed = 5f;
    private float interpolationValue;

    private void Update()
    {
        // Determine the distance between the player and the target object
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // Calculate the interpolation value as a fraction of the distance
        float interpolationValue = Mathf.Clamp01(distance / moveSpeed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GrappleRope1")
        {
            transform.position = Vector3.Lerp(transform.position, targetObject.position, interpolationValue * Time.deltaTime * moveSpeed);
        }
    }
}