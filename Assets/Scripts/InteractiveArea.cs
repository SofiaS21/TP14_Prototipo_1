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
        Collectable objeto = other.GetComponent<Collectable>();

            if (other.CompareTag("Collectable"))
            {
                score++;

                if (objeto != null)
                {
                    uiManagerScript.MostrarObjeto(objeto.icono);
                }

                uiManagerScript.UpdateScore(score);

                Destroy(other.gameObject);
            }

            if (other.CompareTag("DoubleCollectable"))
            {
                score += 2;

                if (objeto != null)
                {
                    uiManagerScript.MostrarObjeto(objeto.icono);
                }

                uiManagerScript.UpdateScore(score);

                Destroy(other.gameObject);
            }

                if (score >= 14)
                {
                    uiManagerScript.ShowWonPanel();

                    gameManagerScript.juegoTerminado = true;

                    Time.timeScale = 0;
                }
    }
}

