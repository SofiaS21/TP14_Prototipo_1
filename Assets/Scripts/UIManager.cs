using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
  
    public TextMeshProUGUI contadorTexto;
    public TextMeshProUGUI timerTexto;

    void Start()
    {
        contadorTexto.Text = "Score: 0";
    }

    public void UpdateScore (int score)
    {
        contadorTexto.Text = "Score:" + score + score;
    }

    public void UpdateTimer(float timer)
    {
        timerTexto.text = "timer: 00:" + Mathf.Ceil(timer);
    }

}