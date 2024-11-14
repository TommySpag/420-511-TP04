//using UnityEngine;

//public class HealthBarManager : MonoBehaviour

//{

//    public HealthBar healthBar; // Référence à la barre de santé (assurez-vous qu'elle est assignée dans l'inspecteur)

//    private float currentHealth;

//    private float maxHealth = 100f;

//    void Start()

//    {

//        currentHealth = maxHealth;

//        healthBar.SetMaxHealth(maxHealth); // Initialiser la barre de santé avec la valeur maximale

//        Debug.Log("Santé initialisée à : " + currentHealth); // Vérifiez que la santé est bien initialisée

//    }

//    void Update()

//    {

//        foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))

//        {

//            if (Input.GetKey(vKey))

//            {

//                Debug.Log("Touche détectée : " + vKey);
//                TakeDamage(10);

//            }

//        }

//    }

//    // Fonction pour infliger des dégâts au joueur

//    public void TakeDamage(float damageAmount)

//    {

//        currentHealth -= damageAmount;

//        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Limiter la santé entre 0 et la santé max

//        Debug.Log("Dégâts reçus. Santé actuelle : " + currentHealth); // Vérifiez la santé après avoir pris des dégâts

//        healthBar.SetHealth(currentHealth); // Mettre à jour l'interface utilisateur de la barre de santé

//    }

//}


using UnityEngine;
using System;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    public HealthBar healthBar; // Référence à la barre de santé

    private float currentHealth;
    private float maxHealth = 1f;
    public Text txt;

    void Start()
    {
        Debug.Log("Démarrage du script HealthBarManager"); // Debug pour vérifier que Start est bien appelé
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); // Initialiser la barre de santé avec la valeur maximale
        txt = transform.Find("HealthValue").GetComponent<Text>();
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            GameObject.Find("ClairePlayer").GetComponent<ClaireController>().ClaireDead();
        }
        txt.text = ((Math.Round(currentHealth * 100))).ToString() + "%";
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Limiter la santé entre 0 et la santé max
        Debug.Log("Santé actuelle après dégâts : " + currentHealth); // Vérifier que la santé est correctement calculée
        healthBar.SetHealth(currentHealth); // Appeler la mise à jour de la barre de santé
    }
}