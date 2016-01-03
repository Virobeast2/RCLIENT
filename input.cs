using System;
using UnityEngine;

public class input : ConsoleSystem
{
    [Saved, Help("Should we flip the mouse pitch movement? Default is false", ""), ConsoleSystem.Client]
    public static bool flipy;
    [Saved, Help("The mouse sensitivity. Default is 5.0", ""), ConsoleSystem.Client]
    public static float mousespeed = 5f;

    [ConsoleSystem.Client, Help("Internal use only", "")]
    public static void bind(ref ConsoleSystem.Arg args)
    {
        if (args.HasArgs(3))
        {
            string strName = args.Args[0];
            string a = args.Args[1];
            string b = args.Args[2];
            GameInput.GameButton button = GameInput.GetButton(strName);
            if (button != null)
            {
                button.Bind(a, b);
            }
        }
    }

    [Help("Internal use only", ""), ConsoleSystem.Client]
    public static void keys(ref ConsoleSystem.Arg args)
    {
        Debug.Log(GameInput.GetConfig());
    }

    [Saved]
    public static string save_bound_keys()
    {
        return GameInput.GetConfig();
    }
}

