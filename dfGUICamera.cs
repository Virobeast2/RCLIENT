﻿using System;
using UnityEngine;

[Serializable, ExecuteInEditMode, RequireComponent(typeof(Camera)), AddComponentMenu("Daikon Forge/User Interface/GUI Camera")]
public class dfGUICamera : MonoBehaviour
{
    public void Awake()
    {
    }

    public void OnEnable()
    {
    }

    public void Start()
    {
        base.camera.transparencySortMode = TransparencySortMode.Orthographic;
        base.camera.useOcclusionCulling = false;
        Camera camera = base.camera;
        camera.eventMask &= ~base.camera.cullingMask;
    }
}

