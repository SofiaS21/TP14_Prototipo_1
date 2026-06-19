using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgreso : MonoBehaviour
{
    Slider Barra;

    public float max;
    public float act;

    void Awake()
    {
        Barra = GetComponent<Slider> ();
    }

    void Update(){
        ActualizarValorBarra (max, act);
    }

    void ActualizarValorBarra (float valorMax, float valorAct){
        float porcentaje;
        porcentaje = valorAct / valorMax;
        Barra.value = porcentaje;
    }

}
