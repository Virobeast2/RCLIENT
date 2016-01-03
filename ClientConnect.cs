using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using uLink;
using UnityEngine;

public class ClientConnect : UnityEngine.MonoBehaviour
{
    [NonSerialized]
    private GameObject levelLoader;

    public bool DoConnect(string strURL, int iPort)
    {
        SteamClient.Needed();
        NetCull.config.timeoutDelay = 60f;
        if (Steam_GetSteamID() == 0)
        {
            LoadingScreen.Update("connection failed (no steam detected)");
            UnityEngine.Object.Destroy(base.gameObject);
            return false;
        }
        byte[] buffer = new byte[0x400];
        IntPtr pData = Marshal.AllocHGlobal(0x400);
        uint num2 = SteamClient_GetAuth(pData, 0x400);
        byte[] destination = new byte[num2];
        Marshal.Copy(pData, destination, 0, (int) num2);
        Marshal.FreeHGlobal(pData);
        uLink.BitStream stream = new uLink.BitStream(false);
        stream.WriteInt32(0x42d);
        stream.WriteByte(2);
        stream.WriteUInt64(Steam_GetSteamID());
        stream.WriteString(Marshal.PtrToStringAnsi(Steam_GetDisplayname()));
        stream.WriteBytes(destination);
        try
        {
            object[] loginData = new object[] { stream };
            NetError error = NetCull.Connect(strURL, iPort, string.Empty, loginData);
            if (error != NetError.NoError)
            {
                LoadingScreen.Update("connection failed (" + error + ")");
                UnityEngine.Object.Destroy(base.gameObject);
                return false;
            }
        }
        catch (Exception exception)
        {
            UnityEngine.Debug.LogException(exception);
            UnityEngine.Object.Destroy(base.gameObject);
            return false;
        }
        SteamClient.SteamClient_OnJoinServer(strURL, iPort);
        return true;
    }

    public static ClientConnect Instance()
    {
        GameObject target = new GameObject();
        UnityEngine.Object.DontDestroyOnLoad(target);
        return target.AddComponent<ClientConnect>();
    }

    [DebuggerHidden]
    private IEnumerator LoadLevel(string levelName)
    {
        return new <LoadLevel>c__Iterator3F { levelName = levelName, <$>levelName = levelName, <>f__this = this };
    }

    [DllImport("librust")]
    public static extern IntPtr Steam_GetDisplayname();
    [DllImport("librust")]
    public static extern ulong Steam_GetSteamID();
    [DllImport("librust")]
    public static extern uint SteamClient_GetAuth(IntPtr pData, int iMaxLength);
    private void uLink_OnConnectedToServer()
    {
        LoadingScreen.Update("connected!");
        uLink.BitStream stream = new uLink.BitStream((byte[]) NetCull.approvalData.ReadObject(typeof(byte[]).TypeHandle, new object[0]), false);
        string levelName = stream.ReadString();
        NetCull.sendRate = stream.ReadSingle();
        string str2 = stream.ReadString();
        bool flag = stream.ReadBoolean();
        bool flag2 = stream.ReadBoolean();
        if (stream.bytesRemaining > 8)
        {
            ulong serverid = stream.ReadUInt64();
            uint serverip = stream.ReadUInt32();
            int serverport = stream.ReadInt32();
            SteamClient.SteamUser_AdvertiseGame(serverid, serverip, serverport);
        }
        UnityEngine.Debug.Log("Server Name: \"" + str2 + "\"");
        UnityEngine.Debug.Log("Level Name: \"" + levelName + "\"");
        UnityEngine.Debug.Log("Send Rate: " + NetCull.sendRate);
        NetCull.isMessageQueueRunning = false;
        base.StartCoroutine(this.LoadLevel(levelName));
        DisableOnConnectedState.OnConnected();
    }

    private void uLink_OnDisconnectedFromServer(uLink.NetworkDisconnection netDisconnect)
    {
        if (this.levelLoader != null)
        {
            UnityEngine.Object.Destroy(this.levelLoader);
        }
        try
        {
            DisableOnConnectedState.OnDisconnected();
        }
        finally
        {
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }

    private void uLink_OnFailedToConnect(uLink.NetworkConnectionError ulink_error)
    {
        if (this.levelLoader != null)
        {
            UnityEngine.Object.Destroy(this.levelLoader);
        }
        if (MainMenu.singleton == null)
        {
            NetError error = ulink_error.ToNetError();
            if (error != NetError.NoError)
            {
                UnityEngine.Debug.LogError(error.NiceString());
            }
        }
        try
        {
            DisableOnConnectedState.OnDisconnected();
        }
        finally
        {
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }

    [CompilerGenerated]
    private sealed class <LoadLevel>c__Iterator3F : IDisposable, IEnumerator, IEnumerator<object>
    {
        internal object $current;
        internal int $PC;
        internal string <$>levelName;
        internal ClientConnect <>f__this;
        internal AudioSource <audioSource>__0;
        internal string levelName;

        [DebuggerHidden]
        public void Dispose()
        {
            this.$PC = -1;
        }

        public bool MoveNext()
        {
            uint num = (uint) this.$PC;
            this.$PC = -1;
            switch (num)
            {
                case 0:
                    this.<audioSource>__0 = this.<>f__this.GetComponentInChildren<AudioSource>();
                    if (this.<audioSource>__0 != null)
                    {
                        this.<audioSource>__0.enabled = false;
                    }
                    this.$current = RustLevel.Load(this.levelName, out this.<>f__this.levelLoader);
                    this.$PC = 1;
                    return true;

                case 1:
                    GameEvent.DoQualitySettingsRefresh();
                    UnityEngine.Object.Destroy(this.<>f__this.gameObject);
                    this.$PC = -1;
                    break;
            }
            return false;
        }

        [DebuggerHidden]
        public void Reset()
        {
            throw new NotSupportedException();
        }

        object IEnumerator<object>.Current
        {
            [DebuggerHidden]
            get
            {
                return this.$current;
            }
        }

        object IEnumerator.Current
        {
            [DebuggerHidden]
            get
            {
                return this.$current;
            }
        }
    }
}

