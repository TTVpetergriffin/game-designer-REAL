using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// The Mink Tracker
public class playerController : MonoBehaviour
{
    public int Minksleft;
    public TextMeshProUGUI MinkText;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealth(0);
        Minksleft = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mink")
        {
            Minksleft--;
            UpdateHealth(0);
        }
        if (collision.gameObject.tag == "Killzone")
        {
            Player.transform.position = new Vector3(19.1200008f, 6.88999987f, -38.1100006f);
        }
    }
    private void UpdateHealth(int healthToSteal)
    {
        Minksleft += healthToSteal;
        MinkText.text = "Minks left: " + Minksleft;
    }
}
