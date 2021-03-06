﻿using System;
using System.IO;

public class config : ConsoleSystem
{
    public const string defaultConfig = "\r\necho default config\r\ninput.bind Left A None\r\ninput.bind Right D None\r\ninput.bind Up W None\r\ninput.bind Down S None\r\ninput.bind Jump Space None\r\ninput.bind Duck LeftControl None\r\ninput.bind Sprint LeftShift None\r\ninput.bind Fire Mouse0 None\r\ninput.bind AltFire Mouse1 None\r\ninput.bind Reload R None\r\ninput.bind Use E None\r\ninput.bind Inventory Tab None\r\ninput.bind Flashlight F None\r\ninput.bind Laser G None\r\ninput.bind Voice V None\r\ninput.bind Chat Return T\r\nrender.update\r\n";

    public static string ConfigName()
    {
        return "cfg/client.cfg";
    }

    [User, ConsoleSystem.Client, Help("Load the current config from config.cfg", ""), Admin]
    public static void load(ref ConsoleSystem.Arg arg)
    {
        string path = ConfigName();
        string strFile = "\r\necho default config\r\ninput.bind Left A None\r\ninput.bind Right D None\r\ninput.bind Up W None\r\ninput.bind Down S None\r\ninput.bind Jump Space None\r\ninput.bind Duck LeftControl None\r\ninput.bind Sprint LeftShift None\r\ninput.bind Fire Mouse0 None\r\ninput.bind AltFire Mouse1 None\r\ninput.bind Reload R None\r\ninput.bind Use E None\r\ninput.bind Inventory Tab None\r\ninput.bind Flashlight F None\r\ninput.bind Laser G None\r\ninput.bind Voice V None\r\ninput.bind Chat Return T\r\nrender.update\r\n";
        if (File.Exists(path))
        {
            strFile = File.ReadAllText(path);
        }
        ConsoleSystem.RunFile(strFile);
        arg.ReplyWith("Loaded " + path);
    }

    [Help("Save the current config to config.cfg", ""), Admin, User, ConsoleSystem.Client]
    public static void save(ref ConsoleSystem.Arg arg)
    {
        if (!Directory.Exists("cfg"))
        {
            Directory.CreateDirectory("cfg");
        }
        string path = ConfigName();
        string contents = ConsoleSystem.SaveToConfigString();
        File.WriteAllText(path, contents);
        arg.ReplyWith("Saved config.cfg");
    }
}

