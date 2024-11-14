using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (GameObject.Find("ClairePlayer").GetComponent<ClaireController>().isJumping)
            {
                GameObject.Find("ParticulesDamage").GetComponent<ParticleActivator>().activate();
                collisionCount++;

                if (collisionCount >= 3)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                GameObject.Find("HealthBar").GetComponent<HealthBarManager>().TakeDamage(0.23f);
            }
        }
    }
}
