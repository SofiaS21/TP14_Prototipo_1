using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{

 public GameObject goCartelColectados;

    // Start is called before the first frame update
    void Start()
    {
        goCartelColectados = GameObject.FindGameObjectWithTag("Contador");
        HideCartelColectados();
    }

    public void ShowCartelColectados()
    {
        goCartelColectados.SetActive(true);
    }

    public void HideCartelColectados()
    {
        goCartelColectados.SetActive(false);
    }

}