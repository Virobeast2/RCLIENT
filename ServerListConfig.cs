using JSON;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ServerListConfig : MonoBehaviour
{
    private GameConfig config;
    public static ServerListConfig instance;

    public static bool IsBadServer(string serverIP)
    {
        if (instance != null)
        {
            if (!instance.config.isLoaded)
            {
                return false;
            }
            IEnumerator<Value> enumerator = instance.config.json.GetArray("servers_blacklist").GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Value current = enumerator.Current;
                    if (serverIP.StartsWith(current.Str))
                    {
                        return true;
                    }
                }
            }
            finally
            {
                if (enumerator == null)
                {
                }
                enumerator.Dispose();
            }
        }
        return false;
    }

    public static bool IsOfficialServer(string serverIP)
    {
        if (instance != null)
        {
            if (!instance.config.isLoaded)
            {
                return false;
            }
            IEnumerator<Value> enumerator = instance.config.json.GetArray("servers_official").GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Value current = enumerator.Current;
                    if (serverIP.StartsWith(current.Str))
                    {
                        return true;
                    }
                }
            }
            finally
            {
                if (enumerator == null)
                {
                }
                enumerator.Dispose();
            }
        }
        return false;
    }

    private void Start()
    {
        instance = this;
        this.config = base.GetComponent<GameConfig>();
    }
}

