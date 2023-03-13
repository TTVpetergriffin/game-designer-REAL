using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Wallrunning : MonoBehaviour
{
    public bool wallrunwork;
    public GameObject player;
    public ConstantForce gravity;
    public bool onwall;
    // Start is called before the first frame update
    void Start()
    {
        wallrunwork = true;
        onwall = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            gravity = gameObject.AddComponent<ConstantForce>();
            gravity.force = new Vector3(0.0f, -9.81f, 0.0f);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            onwall = true;
        }
    }
}
