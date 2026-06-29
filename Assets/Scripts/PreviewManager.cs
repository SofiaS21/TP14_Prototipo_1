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

objetoActual = Instantiate(prefab);

objetoActual.transform.position = spawnPreview.position;
objetoActual.transform.rotation = spawnPreview.rotation;
objetoActual.transform.localScale = Vector3.one * 0.2f;

            objetoActual.transform.SetParent(spawnPreview);

            objetoActual.AddComponent<RotarPreview>();
        }
}
