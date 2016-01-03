using System;

public class serverfavourite : ConsoleSystem
{
    [ConsoleSystem.Client, Help("Adds a server to favourites", "")]
    public static void add(ref ConsoleSystem.Arg arg)
    {
        FavouriteList.Add(arg.GetString(0, string.Empty));
    }

    [Help("Load fave list", ""), ConsoleSystem.Client]
    public static void load(ref ConsoleSystem.Arg arg)
    {
        FavouriteList.Load();
    }

    [Help("Removes a server to favourites", ""), ConsoleSystem.Client]
    public static void remove(ref ConsoleSystem.Arg arg)
    {
        FavouriteList.Remove(arg.GetString(0, string.Empty));
    }

    [Help("Save fave list", ""), ConsoleSystem.Client]
    public static void save(ref ConsoleSystem.Arg arg)
    {
        FavouriteList.Save();
    }
}

