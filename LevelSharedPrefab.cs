using System;
using UnityEngine;

public class LevelSharedPrefab : MonoBehaviour
{
    private void Awake()
    {
        base.transform.DetachChildren();
        UnityEngine.Object.Destroy(this);
    }
}

