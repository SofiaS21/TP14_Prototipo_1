using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewManager : MonoBehaviour
{
    public Transform spawnPreview;
    private GameObject objetoActual;

        public void MostrarObjeto(GameObject prefab)
        {
            if (objetoActual != null)
            {
                Destroy(objetoActual);
            }

            objetoActual = Instantiate(prefab, spawnPreview.position, Quaternion.identity);

            objetoActual.transform.SetParent(spawnPreview);

            objetoActual.AddComponent<RotarPreview>();
        }
}
