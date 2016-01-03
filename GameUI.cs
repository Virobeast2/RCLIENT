using System;

public class gameui : ConsoleSystem
{
    [ConsoleSystem.Client]
    public static void hide(ref ConsoleSystem.Arg arg)
    {
        MainMenu.singleton.Hide();
    }

    [ConsoleSystem.Client]
    public static void show(ref ConsoleSystem.Arg arg)
    {
        MainMenu.singleton.Show();
    }
}

