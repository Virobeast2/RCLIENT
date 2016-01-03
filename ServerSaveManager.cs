using System;
using UnityEngine;

[AddComponentMenu("")]
public class ServerSaveManager : MonoBehaviour
{
    [HideInInspector, SerializeField]
    private int[] keys;
    [SerializeField, HideInInspector]
    private int nextID = 1;
    [SerializeField, HideInInspector]
    private ServerSave[] values;
}

