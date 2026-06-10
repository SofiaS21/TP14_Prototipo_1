using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;
    UIManager uiManagerScript;
    GameManager gameManagerScript;
    public GameObject gameWonPanel; 


    void Awake ()

    {
        uiManagerScript = FindObjectOfType<UIManager>();
        gameManagerScript = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            score++;

            uiManagerScript.UpdateScore(score);

            Destroy(other.gameObject);

            if (score >= 11)
            {
                uiManagerScript.ShowWonPanel();

                gameManagerScript.juegoTerminado = true;

                Time.timeScale = 0;
            }
        }
    }
}
