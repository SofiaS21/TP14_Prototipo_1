using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
  
    public TextMeshProUGUI contadorTexto;
    public TextMeshProUGUI timerTexto;
    
    public GameObject gameOverPanel;
    public GameObject gameWonPanel; 

    public Image imagenObjeto;
    
    void Start()
    {
        contadorTexto.text = "Score: 0";

        gameOverPanel.SetActive(false);
        gameWonPanel.SetActive(false);
    }

    public void UpdateScore (int score)
    {
        contadorTexto.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        timerTexto.text = "timer: 00:" + Mathf.Ceil(timer);
    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void ShowWonPanel()
    {
        gameWonPanel.SetActive(true);
    }

    public void MostrarObjeto(Sprite sprite)
    {
        imagenObjeto.sprite = sprite;
        imagenObjeto.gameObject.SetActive(true);
    }

}