using System;

public class deathscreen : ConsoleSystem
{
    [ConsoleSystem.Client]
    public static string reason = "...";

    [ConsoleSystem.Client]
    public static void show(ref ConsoleSystem.Arg arg)
    {
        DeathScreen.Show();
    }
}

