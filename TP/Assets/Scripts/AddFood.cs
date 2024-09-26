using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFood : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("BarFood").GetComponent<BarManager>().HealDamage(5.0f);
        }
    }
}
