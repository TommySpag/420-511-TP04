using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            GameObject.Find("HealthBar").GetComponent<HealthBarManager>().TakeDamage(0.1f);
        }
    }
}
