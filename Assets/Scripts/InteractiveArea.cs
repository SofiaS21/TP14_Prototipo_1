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
 
    void Awake()
    {
        uiManagerScript = FindObjectOfType<UIManager>();
        gameManagerScript = FindObjectOfType<GameManager>();
        previewManager = FindObjectOfType<PreviewManager>(); 
    }
 
    void OnTriggerEnter(Collider other)
    {
        Collectable objeto = other.GetComponent<Collectable>();
 
        if (other.CompareTag("Collectable"))
        {
            score++;
 
            MostrarPreviewSeguro(objeto, other.gameObject.name); 
 
            uiManagerScript.UpdateScore(score);
            Destroy(other.gameObject);
        }
 
        if (other.CompareTag("DoubleCollectable"))
        {
            score += 2;
 
            MostrarPreviewSeguro(objeto, other.gameObject.name); 
 
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
 
    void MostrarPreviewSeguro(Collectable objeto, string nombre)
    {
        if (objeto == null) return;
 
        if (objeto.previewPrefab != null)
        {
            previewManager.MostrarObjeto(objeto.previewPrefab);
        }
        else
        {
            Debug.LogWarning("Falta previewPrefab en: " + nombre);
        }
    }
}