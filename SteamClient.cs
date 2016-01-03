using Rust.Steam;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Cloud.Analytics;

public class SteamClient : MonoBehaviour
{
    public static GameObject steamClientObject;
    protected static Vector3 vOldPosition = Vector3.zero;

    public static void Create()
    {
        if (!SteamClient_Init())
        {
            Application.Quit();
        }
        else
        {
            steamClientObject = new GameObject();
            UnityEngine.Object.DontDestroyOnLoad(steamClientObject);
            steamClientObject.AddComponent<SteamClient>();
            steamClientObject.name = "SteamClient";
        }
    }

    public static void Needed()
    {
        if (steamClientObject == null)
        {
            Create();
        }
    }

    public void OnDestroy()
    {
        SteamClient_Shutdown();
    }

    public void Start()
    {
        SteamGroups.Init();
        UnityAnalytics.SetUserId(ClientConnect.Steam_GetSteamID().ToString());
        UnityAnalytics.StartSDK("9fb52793-aff8-4ef9-9381-1c26affde21e");
    }

    [DllImport("librust")]
    public static extern void SteamClient_Cycle();
    [DllImport("librust")]
    public static extern bool SteamClient_Init();
    [DllImport("librust")]
    public static extern void SteamClient_OnJoinServer(string strHost, int iIP);
    [DllImport("librust")]
    public static extern void SteamClient_Shutdown();
    [DllImport("librust")]
    public static extern void SteamUser_AdvertiseGame(ulong serverid, uint serverip, int serverport);
    public void Update()
    {
        SteamClient_Cycle();
    }
}

