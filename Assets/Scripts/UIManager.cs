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
        contadorTexto.text = "Score: 0";
    }

    public void UpdateScore (int score)
    {
        contadorTexto.text = "Score:" + score;
    }

    public void UpdateTimer(float timer)
    {
        timerTexto.text = "timer: 00:" + Mathf.Ceil(timer);
    }

}