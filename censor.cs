using System;

public class censor : ConsoleSystem
{
    [ConsoleSystem.Client, User]
    public static bool nudity
    {
        get
        {
            return ArmorModelRenderer.Censored;
        }
        set
        {
            ArmorModelRenderer.Censored = value;
        }
    }
}

