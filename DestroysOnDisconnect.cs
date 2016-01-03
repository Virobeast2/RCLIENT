using System;
using System.Collections.Generic;
using uLink;
using UnityEngine;

public sealed class DestroysOnDisconnect : UnityEngine.MonoBehaviour
{
    private bool inList;
    private static bool ListClassInitialized;

    public static void ApplyToGameObject(GameObject gameObject)
    {
        if (gameObject.GetComponent<DestroysOnDisconnect>() == null)
        {
            gameObject.AddComponent<DestroysOnDisconnect>();
        }
    }

    private void Awake()
    {
        if (!this.inList)
        {
            this.inList = true;
            try
            {
                List.all.Add(this);
            }
            catch
            {
                this.inList = false;
                throw;
            }
        }
    }

    private void DestroyManually()
    {
        if (this.inList)
        {
            UnityEngine.Object.Destroy(base.gameObject);
        }
    }

    private void OnDestroy()
    {
        if (this.inList)
        {
            try
            {
                if (!List.all.Remove(this))
                {
                    Debug.LogWarning("serious problem, script reload?", this);
                }
            }
            finally
            {
                this.inList = false;
            }
        }
    }

    public static void OnDisconnectedFromServer()
    {
        if (ListClassInitialized && (List.all.Count > 0))
        {
            foreach (DestroysOnDisconnect disconnect in List.all.ToArray())
            {
                if (disconnect != null)
                {
                    UnityEngine.Object.Destroy(disconnect.gameObject);
                }
            }
        }
    }

    private void uLink_OnDisconnectedFromServer(uLink.NetworkDisconnection blowme)
    {
        this.DestroyManually();
    }

    private static class List
    {
        public static readonly System.Collections.Generic.List<DestroysOnDisconnect> all = new System.Collections.Generic.List<DestroysOnDisconnect>();

        static List()
        {
            DestroysOnDisconnect.ListClassInitialized = true;
        }
    }
}

