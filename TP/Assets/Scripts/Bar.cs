using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Slider slider;

    // Fonction pour initialiser la barre à la valeur maximale
    public void SetMaxHealth(float maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
    }

    // Utilise une Coroutine pour mettre à jour progressivement la barre
    public void SetHealth(float health)
    {
        StartCoroutine(SmoothHealthTransition(health));
    }

    // Coroutine pour animer la transition de la barre
    private IEnumerator SmoothHealthTransition(float targetHealth)
    {
        while (Mathf.Abs(slider.value - targetHealth) > 0.01f)
        {
            slider.value = Mathf.Lerp(slider.value, targetHealth, Time.deltaTime * 5);
            yield return null; // Attendre le frame suivant avant de continuer la boucle
        }
        slider.value = targetHealth;
        Canvas.ForceUpdateCanvases(); // Assurez-vous que le Canvas est à jour
    }
}