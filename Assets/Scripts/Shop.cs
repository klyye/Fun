using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // TODO: Gold component?
    private Shooter _shooter;

    private void Start()
    {
        _shooter = GameManager.player.GetComponent<Shooter>();
    }

    public void UpgradeDoubleShot()
    {
        _shooter.doubleShot = true;
    }

    public void UpgradePiercingShot()
    {
        _shooter.piercingShot = true;
    }

    public void UpgradeHeatSeekingShot()
    {
        _shooter.heatSeekingShot = true;
    }
}