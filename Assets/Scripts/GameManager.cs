using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float timer = 60f;
    public TextMeshProUGUI timerTexto;


    UIManager uiManagerScript;

    void Awake ()
    {
        uiManagerScript = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        uiManagerScript.UpdateTimer(timer);   
        }
}

