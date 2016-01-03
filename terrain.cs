using System;

internal class terrain : ConsoleSystem
{
    [ConsoleSystem.Client, Help("The interval (seconds) to force tree redrawing when there is no camera movement. Set to zero if you do not want forced tree drawing", "")]
    public static float idleinterval = 3.2f;
    [ConsoleSystem.Client]
    public static bool manual;

    [ConsoleSystem.Client]
    public static void flush(ref ConsoleSystem.Arg arg)
    {
        TerrainControl.ter_flush();
    }

    [ConsoleSystem.Client]
    public static void flushtrees(ref ConsoleSystem.Arg arg)
    {
        TerrainControl.ter_flushtrees();
    }

    [ConsoleSystem.Client]
    public static void mat(ref ConsoleSystem.Arg arg)
    {
        TerrainControl.ter_mat();
    }

    [ConsoleSystem.Client]
    public static void reassign(ref ConsoleSystem.Arg arg)
    {
        TerrainControl.ter_reassign();
    }

    [ConsoleSystem.Client]
    public static void reassign_nocopy(ref ConsoleSystem.Arg arg)
    {
        TerrainControl.ter_reassign_nocopy();
    }
}

