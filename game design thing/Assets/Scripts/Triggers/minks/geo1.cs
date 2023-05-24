using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geo1 : MonoBehaviour
{
    public GameObject Geometrytwo;
    public GameObject Geothree;
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
            Destroy(Geometrytwo);
            Destroy(this.gameObject);
            Geothree.SetActive(true);
            Player.transform.position = new Vector3(19.1200008f, 6.88999987f, -38.1100006f);

        }
    }
}
