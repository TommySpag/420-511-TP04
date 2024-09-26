using UnityEngine;
using System;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    public Bar bar; // Référence à la barre

    private float currentHealth;
    private float maxHealth = 1f;
    public Text txt;
    [SerializeField] string value;

    void Start()
    {
        Debug.Log("Démarrage du script BarManager"); // Debug pour vérifier que Start est bien appelé
        currentHealth = maxHealth;
        bar.SetMaxHealth(maxHealth); // Initialiser la barre de santé avec la valeur maximale
        txt = transform.Find(value).GetComponent<Text>();
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            GameObject.Find("ClairePlayer").GetComponent<ClaireController>().setSpeed();
        }
        else
        {
            TakeDamage(0.00001f);
            txt.text = ((Math.Round(currentHealth * 100))).ToString() + "%";
        }
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Limiter la santé entre 0 et la santé max
        Debug.Log("Santé actuelle après dégâts : " + currentHealth); // Vérifier que la santé est correctement calculée
        bar.SetHealth(currentHealth); // Appeler la mise à jour de la barre de santé
    }

    public void HealDamage(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        bar.SetHealth(currentHealth);
    }
}