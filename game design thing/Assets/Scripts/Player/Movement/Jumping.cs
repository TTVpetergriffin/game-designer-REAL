using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jumping : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce;
    public float djumpForce;
    private Rigidbody playerRb;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool djump = false;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
   public void jump()
    {
        if (isOnGround == true) {
            playerRb.velocity = new Vector3(playerRb.velocity.x, jumpForce, playerRb.velocity.z);
        isOnGround = false;
            StartCoroutine(djumpstarter());
        }
        if (djump == true && isOnGround == false)
        {
            playerRb.velocity = new Vector3(playerRb.velocity.x, djumpForce, playerRb.velocity.z);
            djump = false;
        }
    }
    IEnumerator djumpstarter()
    {
        yield return new WaitForSeconds(0.01f);
        djump = true;
    }
}
