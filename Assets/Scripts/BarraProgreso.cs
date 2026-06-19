using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BarraProgreso : MonoBehaviour
{

    public GameObject gameOverPanel;
    public Image barraTiempo;
    float tiempoRestante;
    public float maxTiempo = 6.0f;
 
    void Start()
    {
        tiempoRestante = maxTiempo;
    }

    void ActualizarValorBarra
    {
    }
}

