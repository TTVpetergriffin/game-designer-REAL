using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public GameObject fourfive;
    public GameObject five;
    public GameObject fourone;
    public GameObject fivefive;
    public GameObject RDfivefive;
    public GameObject floorfivefive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(fourfive);
            five.SetActive(true);
            Destroy(fourone);
            fivefive.SetActive(true);
            RDfivefive.SetActive(true);
            floorfivefive.SetActive(true);
        }
    }
}
