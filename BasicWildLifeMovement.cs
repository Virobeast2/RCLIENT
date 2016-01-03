using Facepunch.Procedural;
using System;

public class BasicWildLifeMovement : BaseAIMovement
{
    protected float actualMoveSpeedPerSec;
    private float hullLength = 0.1f;
    [NonSerialized]
    protected Facepunch.Procedural.Direction look;
    public float moveCastOffset = 0.25f;
    public float simRate = 5f;
}

