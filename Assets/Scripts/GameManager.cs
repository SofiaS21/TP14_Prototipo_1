using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public float timer = 60f;

    UIManager uiManagerScript;

    void Awake ()
    {
        uiManagerScript = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        timer -= Time.deltatime;
        uiManagerScript.UpdateTimer(timer);
    }
}
}
