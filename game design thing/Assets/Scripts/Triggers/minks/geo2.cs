using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geo2 : MonoBehaviour
{
    public GameObject Geometrythree;
    public GameObject Geofour;
    public GameObject Geo45;
    public GameObject act41;
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
            Destroy(Geometrythree);
            Destroy(this.gameObject);
            Geofour.SetActive(true);
            Player.transform.position = new Vector3(2.45000005f, 4.65999985f, 0.860000014f);

        }
    }
}
