using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{

public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddPointAndUpdateScoreUI()
    {
        score ++;
        Debug.Log("Puntaje: " + score);
    }
}