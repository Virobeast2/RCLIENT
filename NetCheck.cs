﻿using System;
using uLink;

public class NetCheck
{
    public static bool PlayerValid(uLink.NetworkPlayer ply)
    {
        return ply.isConnected;
    }
}

