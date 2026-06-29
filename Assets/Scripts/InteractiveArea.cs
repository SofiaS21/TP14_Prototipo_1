using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveArea : MonoBehaviour
{

    UIManager uiManagerScript;
    GameManager gameManagerScript;
    PreviewManager previewManager;
    
    public GameObject gameWonPanel; 
    int score = 0;

    void Awake ()

    {
        uiManagerScript = FindObjectOfType<UIManager>();
        gameManagerScript = FindObjectOfType<GameManager>();
        previewManager = FindObjectOfType<PreviewManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        Collectable objeto = other.GetComponent<Collectable>();

            Debug.Log("Entró al Collectable");

if (objeto == null)
{
    Debug.Log("OBJETO ES NULL");
}
else
{
    Debug.Log("Preview: " + objeto.previewPrefab);

    previewManager.MostrarObjeto(objeto.previewPrefab);
}


                if (score >= 14)
                {
                    uiManagerScript.ShowWonPanel();

                    gameManagerScript.juegoTerminado = true;

                    Time.timeScale = 0;
                }
    }
}

