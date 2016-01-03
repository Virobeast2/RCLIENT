using System;
using UnityEngine;

public class TerrainQualitySettings : MonoBehaviour
{
    private void Start()
    {
        this.UpdateQuality();
    }

    private void UpdateQuality()
    {
        Debug.Log("updating terrain quality");
        switch (QualitySettings.currentLevel)
        {
            case QualityLevel.Fastest:
                UnityEngine.Terrain.activeTerrain.treeDistance = 250f;
                UnityEngine.Terrain.activeTerrain.treeBillboardDistance = 30f;
                UnityEngine.Terrain.activeTerrain.treeCrossFadeLength = 5f;
                UnityEngine.Terrain.activeTerrain.treeMaximumFullLODCount = 5;
                UnityEngine.Terrain.activeTerrain.detailObjectDistance = 30f;
                UnityEngine.Terrain.activeTerrain.heightmapPixelError = 20f;
                UnityEngine.Terrain.activeTerrain.heightmapMaximumLOD = 1;
                UnityEngine.Terrain.activeTerrain.basemapDistance = 100f;
                break;

            case QualityLevel.Fast:
                UnityEngine.Terrain.activeTerrain.treeDistance = 500f;
                UnityEngine.Terrain.activeTerrain.treeBillboardDistance = 50f;
                UnityEngine.Terrain.activeTerrain.treeCrossFadeLength = 10f;
                UnityEngine.Terrain.activeTerrain.treeMaximumFullLODCount = 10;
                UnityEngine.Terrain.activeTerrain.detailObjectDistance = 40f;
                UnityEngine.Terrain.activeTerrain.heightmapPixelError = 10f;
                UnityEngine.Terrain.activeTerrain.heightmapMaximumLOD = 1;
                UnityEngine.Terrain.activeTerrain.basemapDistance = 250f;
                break;

            case QualityLevel.Simple:
                UnityEngine.Terrain.activeTerrain.treeDistance = 650f;
                UnityEngine.Terrain.activeTerrain.treeBillboardDistance = 75f;
                UnityEngine.Terrain.activeTerrain.treeCrossFadeLength = 25f;
                UnityEngine.Terrain.activeTerrain.treeMaximumFullLODCount = 20;
                UnityEngine.Terrain.activeTerrain.detailObjectDistance = 60f;
                UnityEngine.Terrain.activeTerrain.heightmapPixelError = 8f;
                UnityEngine.Terrain.activeTerrain.heightmapMaximumLOD = 0;
                UnityEngine.Terrain.activeTerrain.basemapDistance = 500f;
                break;

            case QualityLevel.Good:
                UnityEngine.Terrain.activeTerrain.treeDistance = 800f;
                UnityEngine.Terrain.activeTerrain.treeBillboardDistance = 100f;
                UnityEngine.Terrain.activeTerrain.treeCrossFadeLength = 40f;
                UnityEngine.Terrain.activeTerrain.treeMaximumFullLODCount = 30;
                UnityEngine.Terrain.activeTerrain.detailObjectDistance = 75f;
                UnityEngine.Terrain.activeTerrain.heightmapPixelError = 5f;
                UnityEngine.Terrain.activeTerrain.heightmapMaximumLOD = 0;
                UnityEngine.Terrain.activeTerrain.basemapDistance = 800f;
                break;

            case QualityLevel.Beautiful:
                UnityEngine.Terrain.activeTerrain.treeDistance = 1000f;
                UnityEngine.Terrain.activeTerrain.treeBillboardDistance = 150f;
                UnityEngine.Terrain.activeTerrain.treeCrossFadeLength = 50f;
                UnityEngine.Terrain.activeTerrain.treeMaximumFullLODCount = 50;
                UnityEngine.Terrain.activeTerrain.detailObjectDistance = 100f;
                UnityEngine.Terrain.activeTerrain.heightmapPixelError = 5f;
                UnityEngine.Terrain.activeTerrain.heightmapMaximumLOD = 0;
                UnityEngine.Terrain.activeTerrain.basemapDistance = 1000f;
                break;

            case QualityLevel.Fantastic:
                UnityEngine.Terrain.activeTerrain.treeDistance = 2000f;
                UnityEngine.Terrain.activeTerrain.treeBillboardDistance = 250f;
                UnityEngine.Terrain.activeTerrain.treeCrossFadeLength = 50f;
                UnityEngine.Terrain.activeTerrain.treeMaximumFullLODCount = 100;
                UnityEngine.Terrain.activeTerrain.detailObjectDistance = 200f;
                UnityEngine.Terrain.activeTerrain.heightmapPixelError = 5f;
                UnityEngine.Terrain.activeTerrain.heightmapMaximumLOD = 0;
                UnityEngine.Terrain.activeTerrain.basemapDistance = 1000f;
                break;
        }
    }
}

