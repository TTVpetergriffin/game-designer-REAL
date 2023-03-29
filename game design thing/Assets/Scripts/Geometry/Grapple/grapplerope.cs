using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplerope : MonoBehaviour
{
    public float Johnny;
    // Start is called before the first frame update
    void Start()
    {
        Johnny = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.localScale = new Vector3(Johnny, transform.localScale.y, transform.localScale.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Johnny --;
            
        }
    }
}
