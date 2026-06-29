using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
  
    public TextMeshProUGUI contadorTexto;
    public TextMeshProUGUI timerTexto;
    
    public GameObject gameOverPanel;
    public GameObject gameWonPanel; 
    
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

}