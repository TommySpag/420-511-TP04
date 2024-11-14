using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishGame : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("WinMessage").GetComponent<TextMeshProUGUI>().enabled = true;
            GameObject.Find("GoNext").GetComponent<TextMeshProUGUI>().enabled = true;
            GameObject.Find("EndGame").GetComponent<TextMeshProUGUI>().enabled = true;

            
            Destroy(GameObject.Find("Enemy"));
            Destroy(GameObject.Find("chrono"));
            Destroy(GameObject.Find("ss"));


            GameObject.Find("ButtonListener").GetComponent<EnableButtons>().enabled = true;
        }
    }
}