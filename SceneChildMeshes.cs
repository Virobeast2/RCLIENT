using System;
using UnityEngine;

public class SceneChildMeshes : MonoBehaviour
{
    private static SceneChildMeshes lastFound;
    [SerializeField]
    private UnityEngine.Mesh[] sceneMeshes;
    [SerializeField]
    private UnityEngine.Mesh[] treeMeshes;

    private static SceneChildMeshes GetMapSingleton(bool canCreate)
    {
        if (lastFound == null)
        {
            UnityEngine.Object[] objArray = UnityEngine.Object.FindObjectsOfType(typeof(SceneChildMeshes));
            if (objArray.Length == 0)
            {
                if (canCreate)
                {
                    System.Type[] components = new System.Type[] { typeof(SceneChildMeshes) };
                    GameObject obj3 = new GameObject("__Scene Child Meshes", components) {
                        hideFlags = HideFlags.HideInHierarchy
                    };
                    lastFound = obj3.GetComponent<SceneChildMeshes>();
                }
            }
            else
            {
                lastFound = (SceneChildMeshes) objArray[0];
            }
        }
        return lastFound;
    }
}

