using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable, AddComponentMenu("Daikon Forge/User Interface/Animation Clip")]
public class dfAnimationClip : MonoBehaviour
{
    [SerializeField]
    private dfAtlas atlas;
    [SerializeField]
    private System.Collections.Generic.List<string> sprites = new System.Collections.Generic.List<string>();

    public dfAtlas Atlas
    {
        get
        {
            return this.atlas;
        }
        set
        {
            this.atlas = value;
        }
    }

    public System.Collections.Generic.List<string> Sprites
    {
        get
        {
            return this.sprites;
        }
    }
}

