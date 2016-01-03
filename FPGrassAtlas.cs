using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FPGrassAtlas : ScriptableObject, IFPGrassAsset
{
    public const int max_textures = 0x10;
    public System.Collections.Generic.List<FPGrassProperty> properties = new System.Collections.Generic.List<FPGrassProperty>();
    public Texture2D textureAtlas;
    public System.Collections.Generic.List<Texture2D> textures = new System.Collections.Generic.List<Texture2D>();

    private void Initialize()
    {
        this.textures.Clear();
        this.properties.Clear();
        for (int i = 0; i < 0x10; i++)
        {
            this.textures.Add(null);
        }
        for (int j = 0; j < 0x10; j++)
        {
            this.properties.Add(ScriptableObject.CreateInstance<FPGrassProperty>());
        }
    }

    private void OnEnable()
    {
        if (this.textures.Count == 0)
        {
            this.Initialize();
        }
    }
}

