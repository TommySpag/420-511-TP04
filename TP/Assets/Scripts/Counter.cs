using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public float Timer = 60;
    [SerializeField] private ClaireController _player;
    [SerializeField] private HealthBar _healthBar;

    IEnumerator ChangeTimer()
    {
        while (Timer > 0)
        {
            Timer--;
            gameObject.GetComponent<Text>().text = Timer + "";
            print(Timer);

            if (_healthBar.healthSlider.value == 0)
            {
                Timer = 0;
            }

            yield return new WaitForSeconds(1);
        }

        UnityEditor.EditorApplication.isPlaying = false;
    }

    void Start()
    {
        StartCoroutine(ChangeTimer());
    }
}
