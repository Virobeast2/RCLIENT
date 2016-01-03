﻿using System;

public class env : ConsoleSystem
{
    [Admin, Help("The length of a day in real minutes", "")]
    public static float daylength = 45f;
    [Help("The length of a night in real minutes", ""), Admin]
    public static float nightlength = 15f;

    [Admin, Help("Gets or sets the current time", "")]
    public static void time(ref ConsoleSystem.Arg arg)
    {
        if (EnvironmentControlCenter.Singleton != null)
        {
            arg.ReplyWith("Current Time: " + EnvironmentControlCenter.Singleton.GetTime().ToString());
        }
    }
}

