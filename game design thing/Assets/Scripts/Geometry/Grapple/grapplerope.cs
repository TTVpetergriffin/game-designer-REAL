using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplerope : MonoBehaviour
{
    public float Marcus;
    public float Johnny;
    // Start is called before the first frame update
    void Start()
    {
        Marcus = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Marcus = 5;
        Johnny = transform.localScale.x - Marcus;
        transform.localScale = new Vector3(Johnny, transform.localScale.y, transform.localScale.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Marcus -1;

        }
    }
}
