using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
  
    public TextMeshProUGUI contadorTexto;
    public TextMeshProUGUI timerTexto;

    void Start()
    {
        puntajeTexto.Text = "Score: 0";
    }

    public void UpdateScore (int score)
    {
        puntajeTexto.Text = "Score:" + score + score;
    }

    public void UpdateTimer(float timer)
    {
        timerTexto.text = "timer: 00:" + Mathf.Ceil(timer);
    }

}