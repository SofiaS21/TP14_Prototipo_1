using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float timer = 60f;

    public bool juegoTerminado = false;
    public GameObject gameOverPanel;


    UIManager uiManagerScript;

    void Awake()
    {
        Time.timeScale = 1;

        uiManagerScript = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (juegoTerminado)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            uiManagerScript.UpdateTimer(timer);

            if (timer <= 0)
            {
                timer = 0;

                uiManagerScript.UpdateTimer(timer);
                uiManagerScript.ShowGameOverPanel();

                juegoTerminado = true;

                Time.timeScale = 0;
            }
        }
    }
}

