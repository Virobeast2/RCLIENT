using System;
using UnityEngine;

public class ClientStreamLevelLoader : MonoBehaviour
{
    [SerializeField]
    private RustLoader loaderPrefab;

    private void Start()
    {
        RustLoader loader = (RustLoader) UnityEngine.Object.Instantiate(this.loaderPrefab);
        base.enabled = false;
    }
}

