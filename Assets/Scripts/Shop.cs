using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private Shooter _shooter;

    private void Start()
    {
        _shooter = GameManager.player.GetComponent<Shooter>();
    }

    public void UpgradeDoubleShot(int cost)
    {
        if (GameManager.gold >= cost)
        {
            GameManager.gold -= cost;
            _shooter.doubleShot = true;
        }
    }

    public void UpgradePiercingShot(int cost)
    {
        if (GameManager.gold >= cost)
        {
            GameManager.gold -= cost;
            _shooter.piercingShot = true;
        }
    }

    public void UpgradeHeatSeekingShot(int cost)
    {
        if (GameManager.gold >= cost)
        {
            GameManager.gold -= cost;
            _shooter.heatSeekingShot = true;
        }
    }
}