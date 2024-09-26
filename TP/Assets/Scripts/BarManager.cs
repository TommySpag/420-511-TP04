using UnityEngine;
using System;
using UnityEngine.UI;

public class BarManager : MonoBehaviour
{
    public Bar bar; // R�f�rence � la barre

    private float currentHealth;
    private float maxHealth = 1f;
    public Text txt;
    [SerializeField] string value;

    void Start()
    {
        Debug.Log("D�marrage du script BarManager"); // Debug pour v�rifier que Start est bien appel�
        currentHealth = maxHealth;
        bar.SetMaxHealth(maxHealth); // Initialiser la barre de sant� avec la valeur maximale
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
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Limiter la sant� entre 0 et la sant� max
        Debug.Log("Sant� actuelle apr�s d�g�ts : " + currentHealth); // V�rifier que la sant� est correctement calcul�e
        bar.SetHealth(currentHealth); // Appeler la mise � jour de la barre de sant�
    }

    public void HealDamage(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        bar.SetHealth(currentHealth);
    }
}