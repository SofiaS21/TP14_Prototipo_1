using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;
    UIManager uiManagerScript;

    void Awake ()

    {
        uiManagerScript = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Collectable"))
        {
            score += 1;

            uiManagerScript.UpdateScore(score);

            Destroy(other.gameObject);
        }
    }
}
