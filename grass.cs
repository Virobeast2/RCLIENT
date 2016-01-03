using System;

public class grass : ConsoleSystem
{
    [Saved, User, ConsoleSystem.Client]
    public static float disp_trail_seconds = 10f;
    [Saved, User, ConsoleSystem.Client]
    public static bool displacement = (FPGrass.Support.Supported && !FPGrass.Support.DisplacementExpensive);
    [Saved, User, ConsoleSystem.Client]
    public static bool forceredraw = false;
    [ConsoleSystem.Client, Saved, User]
    public static bool on = FPGrass.Support.Supported;

    [ConsoleSystem.Client, User, Saved]
    public static bool shadowcast
    {
        get
        {
            return FPGrass.castShadows;
        }
        set
        {
            FPGrass.castShadows = value;
        }
    }

    [Saved, User, ConsoleSystem.Client]
    public static bool shadowreceive
    {
        get
        {
            return FPGrass.receiveShadows;
        }
        set
        {
            FPGrass.receiveShadows = value;
        }
    }
}

