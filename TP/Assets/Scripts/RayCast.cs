using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Déclaration d'un rayon qui sera utilisé pour détecter les obstacles devant le robot
    Ray rayon;

    // Déclaration d'une variable pour stocker les informations de collision lorsque le rayon touche un objet
    RaycastHit hit;

    // Variables sérialisées pour assigner les capteurs gauche et droit du robot dans l'éditeur Unity
    [SerializeField] Transform headSensor, footSensor;

    // Méthode Update appelée à chaque frame du jeu (environ 60 fois par seconde)
    void Update()
    {

        // Création d'un rayon partant de la position du capteur gauche, orienté vers l'avant du robot
        rayon = new Ray(headSensor.position, transform.TransformDirection(Vector3.forward));

        // Si le rayon touche un objet dans le monde
        if (Physics.Raycast(rayon, out hit, Mathf.Infinity))
        {
            // Affiche le nom de l'objet touché et la distance dans la console pour le capteur gauche
            Debug.Log("Head Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);

            // Si l'objet détecté est à moins de 1 unité de distance
            if (hit.distance < 1)
            {

            }
        }

        // Visualise le rayon du capteur gauche dans la vue Scène de Unity (une ligne jaune de 10 unités)
        Debug.DrawRay(headSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);

        // Création d'un rayon partant de la position du capteur droit, orienté vers l'avant du robot
        rayon = new Ray(footSensor.position, transform.TransformDirection(Vector3.forward));

        // Si le rayon touche un objet dans le monde
        if (Physics.Raycast(rayon, out hit, Mathf.Infinity))
        {
            // Affiche le nom de l'objet touché et la distance dans la console pour le capteur droit
            Debug.Log("Foot Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);

            // Si l'objet détecté est à moins de 1 unité de distance
            if (hit.distance < 1)
            {

            }
        }

        // Visualise le rayon du capteur droit dans la vue Scène de Unity (une ligne jaune de 10 unités)
        Debug.DrawRay(footSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
    }
}
