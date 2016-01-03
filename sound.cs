using System;
using UnityEngine;

public class sound : ConsoleSystem
{
    [Help("Global music volume", ""), Saved, ConsoleSystem.Client]
    public static float music = 0.4f;

    [Help("Global sound volume", ""), ConsoleSystem.Client, Saved]
    public static float volume
    {
        get
        {
            return AudioListener.volume;
        }
        set
        {
            AudioListener.volume = value;
        }
    }
}

