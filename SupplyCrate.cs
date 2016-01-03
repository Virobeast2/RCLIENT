using System;
using uLink;
using UnityEngine;

public class SupplyCrate : IDMain, IInterpTimedEventReceiver
{
    public RigidbodyInterpolator _interp;
    protected bool _landed;
    protected bool _landing;
    public GameObject bubbleWrap;
    public SupplyParachute chute;
    public GameObject landedEffect;
    public LootableObject lootableObject;
    protected uLink.RPCMode updateRPCMode;

    public SupplyCrate() : this(IDFlags.Unknown)
    {
    }

    protected SupplyCrate(IDFlags idFlags) : base(idFlags)
    {
        this.updateRPCMode = uLink.RPCMode.Others;
    }

    [RPC]
    protected void GetNetworkUpdate(Vector3 pos, Quaternion rot, uLink.NetworkMessageInfo info)
    {
        this._interp.SetGoals(pos, rot, info.timestamp);
    }

    void IInterpTimedEventReceiver.OnInterpTimedEvent()
    {
        if (InterpTimedEvent.Tag == "LAND")
        {
            this.LandShared();
            GameObject obj2 = UnityEngine.Object.Instantiate(this.landedEffect, base.transform.position, base.transform.rotation) as GameObject;
            UnityEngine.Object.Destroy(obj2, 2.5f);
            this._landed = true;
            this.chute.Landed();
        }
        else
        {
            InterpTimedEvent.MarkUnhandled();
        }
    }

    [RPC]
    public void Landed(uLink.NetworkMessageInfo info)
    {
        InterpTimedEvent.Queue(this, "LAND", ref info);
    }

    private void LandShared()
    {
        this._landed = true;
        if (this.lootableObject != null)
        {
            this.lootableObject.accessLocked = false;
        }
        UnityEngine.Object.Destroy(this.bubbleWrap);
    }

    private void uLink_OnNetworkInstantiate(uLink.NetworkMessageInfo info)
    {
        this.lootableObject.accessLocked = true;
        this._interp.running = true;
        base.rigidbody.isKinematic = true;
    }
}

