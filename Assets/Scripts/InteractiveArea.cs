using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{

    public UIManager uiManager;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Collectable"))
        {
            Debug.Log("Hubo colision con un Collectable");
            Destroy(col.gameObject);
            uiManager.AddPointAndUpdateuiManager();
        }
    }
}
