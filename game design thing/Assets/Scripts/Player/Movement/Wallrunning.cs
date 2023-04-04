using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Wallrunning : MonoBehaviour
{
    public bool wallrunwork;
    public GameObject player;

    public bool onwallLeft;
    public bool onwallRight;
    // Start is called before the first frame update
    void Start()
    {
        wallrunwork = true;
        onwallLeft = false;
        onwallRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onwallLeft == true)
        {
            GetComponent<Rigidbody>().AddForce(9.81f, 0.0f, 0.0f);
        }
        if (onwallRight == true)
        {
            GetComponent<Rigidbody>().AddForce(-9.81f, 0.0f, 0.0f);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "wallLeft")
        {
            
            onwallLeft = true;
        }
        if (other.gameObject.tag == "wallRight")
        {
            onwallRight = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "wallLeft")
        {
            onwallLeft = false;
        }
        if (other.gameObject.tag == "wallRight")
        {
            onwallRight = false;
            
        }
    }
}
