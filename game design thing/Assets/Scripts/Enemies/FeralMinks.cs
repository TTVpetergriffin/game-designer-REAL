using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeralMinks : MonoBehaviour
{
    public float speed;
    public float health;
    private Rigidbody enemyRb;
    private GameObject player;
    public bool danger;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        health = 2f;
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        danger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
        if (danger == true)
        {
            this.transform.LookAt(this.transform.position, player.transform.position);
            //Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            var step = speed * Time.deltaTime; // calculate distance to move
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, step);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
        }
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(hitstop());
        }
    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.name == "dangerzone")
        {
            danger = true;
        }
    }
    IEnumerator hitstop()
    {
        yield return new WaitForSeconds(0);
        speed = 0;
        StartCoroutine(hitrecovery());
    }
    IEnumerator hitrecovery()
    {
        yield return new WaitForSeconds(2);
        speed = 3;
    }
}
