using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // D�claration d'un rayon qui sera utilis� pour d�tecter les obstacles devant le robot
    Ray rayon;

    // D�claration d'une variable pour stocker les informations de collision lorsque le rayon touche un objet
    RaycastHit hit;

    // Variables s�rialis�es pour assigner les capteurs gauche et droit du robot dans l'�diteur Unity
    [SerializeField] Transform headSensor, footSensor;

    // M�thode Update appel�e � chaque frame du jeu (environ 60 fois par seconde)
    void Update()
    {

        // Cr�ation d'un rayon partant de la position du capteur gauche, orient� vers l'avant du robot
        rayon = new Ray(headSensor.position, transform.TransformDirection(Vector3.forward));

        // Si le rayon touche un objet dans le monde
        if (Physics.Raycast(rayon, out hit, Mathf.Infinity))
        {
            // Affiche le nom de l'objet touch� et la distance dans la console pour le capteur gauche
            Debug.Log("Head Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);

            // Si l'objet d�tect� est � moins de 1 unit� de distance
            if (hit.distance < 1)
            {

            }
        }

        // Visualise le rayon du capteur gauche dans la vue Sc�ne de Unity (une ligne jaune de 10 unit�s)
        Debug.DrawRay(headSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);

        // Cr�ation d'un rayon partant de la position du capteur droit, orient� vers l'avant du robot
        rayon = new Ray(footSensor.position, transform.TransformDirection(Vector3.forward));

        // Si le rayon touche un objet dans le monde
        if (Physics.Raycast(rayon, out hit, Mathf.Infinity))
        {
            // Affiche le nom de l'objet touch� et la distance dans la console pour le capteur droit
            Debug.Log("Foot Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);

            // Si l'objet d�tect� est � moins de 1 unit� de distance
            if (hit.distance < 1)
            {

            }
        }

        // Visualise le rayon du capteur droit dans la vue Sc�ne de Unity (une ligne jaune de 10 unit�s)
        Debug.DrawRay(footSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
    }
}
