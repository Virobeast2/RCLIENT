using System;

public class footsteps : ConsoleSystem
{
    [ConsoleSystem.Client, Saved, Help("Footstep Quality, 0 = default sound, 1 = dynamic for local, 2 = dynamic for all. 0-2 (default 2)", "")]
    public static int quality = 2;
}

