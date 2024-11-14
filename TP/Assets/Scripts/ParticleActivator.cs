using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivator : MonoBehaviour
{

    public void activate()
    {
        if (gameObject.GetComponent<ParticleSystem>() != null)
        {
            StartCoroutine(ActivateParticles());
        }
    }

    IEnumerator ActivateParticles()
    {
        gameObject.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<ParticleSystem>().Stop();
    }
}
