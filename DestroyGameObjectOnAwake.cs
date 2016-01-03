using System;
using UnityEngine;

public class DestroyGameObjectOnAwake : MonoBehaviour
{
    private void Awake()
    {
        UnityEngine.Object.Destroy(base.gameObject);
    }
}

