using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activesix : MonoBehaviour
{
    public GameObject five;
    public GameObject fivefive;
    public GameObject RDfivefive;
    public GameObject floorfivefive;
    public GameObject sixgeo;
    public GameObject rd6;
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
            Destroy(five);
            Destroy(fivefive);
            Destroy(RDfivefive);
            Destroy(floorfivefive);
            sixgeo.SetActive(true);
            rd6.SetActive(true);
        }
    }
}
