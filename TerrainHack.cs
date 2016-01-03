using System;
using System.Reflection;
using UnityEngine;

public static class TerrainHack
{
    private static readonly bool AbleToLocateOnTerrainChanged;
    private static MethodInfo OnTerrainChanged = typeof(UnityEngine.Terrain).GetMethod("OnTerrainChanged", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
    private static bool RanOnce;
    private static readonly object[] TriggerTreeChangeValues;
    private static bool Working;

    static TerrainHack()
    {
        if (OnTerrainChanged != null)
        {
            System.Type enumType = System.Type.GetType("UnityEngine.TerrainChangedFlags, UnityEngine", false, false);
            if (enumType != null)
            {
                object obj2;
                try
                {
                    obj2 = Enum.Parse(enumType, "TreeInstances", false);
                }
                catch (Exception exception)
                {
                    Debug.LogException(exception);
                    try
                    {
                        obj2 = Enum.ToObject(enumType, 2);
                    }
                    catch (Exception)
                    {
                        Debug.LogException(exception);
                        return;
                    }
                }
                AbleToLocateOnTerrainChanged = true;
                TriggerTreeChangeValues = new object[] { obj2 };
            }
            else
            {
                Debug.LogWarning("Couldnt locate enum TerrainChangedFlags.");
            }
        }
        else
        {
            Debug.LogWarning("Couldnt locate method OnTerrainChanged");
        }
    }

    public static void RefreshTreeTextures(UnityEngine.Terrain terrain)
    {
        if (terrain == null)
        {
            throw new NullReferenceException();
        }
        if (!RanOnce)
        {
            RanOnce = true;
            if (AbleToLocateOnTerrainChanged)
            {
                try
                {
                    OnTerrainChanged.Invoke(terrain, TriggerTreeChangeValues);
                    Working = true;
                    return;
                }
                catch (Exception exception)
                {
                    Debug.LogException(exception);
                    Working = false;
                }
            }
        }
        if (Working)
        {
            OnTerrainChanged.Invoke(terrain, TriggerTreeChangeValues);
        }
        else
        {
            terrain.Flush();
        }
    }
}

