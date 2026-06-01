using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{

    UIManager uiManagerScript;
    Collectable CollectableScript;


    public bool isInteracting = false;

    // Start is called before the first frame update
    void Start()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
    }


    void OnTriggerEnter(Collider other)
    {
        Collectable CollectableScript = other.GetComponent<Collectable>();
            if(CollectableScript != null)
            {
                uiManagerScript.ShowCartelColectados();
            }
    
    }

    void OnTriggerExit(Collider other)
    {
        uiManagerScript.HideCartelColectados();
    }
}
 