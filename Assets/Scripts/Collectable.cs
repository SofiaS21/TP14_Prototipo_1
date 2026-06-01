using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Collectable collectableScript = other.GetComponent<Collectable>();

        if (collectableScript != null)
        {
            other.gameObject.SetActive(false);
        }
    }
}
