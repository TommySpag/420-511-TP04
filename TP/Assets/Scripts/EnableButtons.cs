using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnableButtons : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene("Spaceship");

        }
        if (Input.GetKey(KeyCode.E))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
