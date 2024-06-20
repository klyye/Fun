using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Upgrade : ScriptableObject
{
    public readonly int cost;
    public readonly UpgradeType type;
    public abstract void apply(Projectile proj);
}

public enum UpgradeType
{
    OnHit, OnSpawn, WhileTraveling
}