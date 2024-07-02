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

// LATEST TODO: two types of upgrade? modify a projectile, do some action
// LATEST TODO: Define what an upgrade can do.
/*
 * Upon an event firing, trigger something
 * That something can be related to a projectile or a weapon or an enemy
 * Modify the stats of some existing thing
 * That thing can be a projectile or a weapon or an enemy
 *      TriggerUpgrade (?)
 *      |
 * Upgrade
 *      |
 *      ModifierUpgrade
 * Idea: Decouple purchasing upgrades from modifiers
 * Build a modifier system and an event trigger/listener system separately
 * Buying an upgrade will apply some modifiers, or create some event listeners, or some mix of both
 * This lets you do upgrades that include both modifiers and events (i.e. a fast moving projectile that explodes on hit)
 */
public enum UpgradeType
{
    OnHit, OnSpawn, WhileTraveling, OnInterval
}