using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geo : MonoBehaviour
{
    public GameObject Geometryone;
    public GameObject Geotwo;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(Geometryone);
            Destroy(this.gameObject);
            Geotwo.SetActive(true);
            Player.transform.position = new Vector3(2.0999999f, 4.9000001f, 0.0799999982f);

        }
    }
}
