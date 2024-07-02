using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile proj;
    [SerializeField] private float interval;
    private float _shotTimer;
    private ISet<Upgrade> upgrades = new HashSet<Upgrade>();

    public void Upgrade(Upgrade upgrade)
    {
        upgrades.Add(upgrade);
    }

    // Update is called once per frame
    private void Update()
    {
        _shotTimer -= Time.deltaTime;
        if (_shotTimer <= 0)
        {
            _shotTimer = interval;
            foreach (var upgrade in upgrades)
            {
                if (upgrade.type == UpgradeType.OnInterval)
                {
                    // upgrade.apply();
                }
            }

            Shoot();
        }
    }

    public void Shoot()
    {
        var shot = Instantiate(proj);
        foreach (var upgrade in upgrades)
        {
            if (upgrade.type == UpgradeType.OnSpawn)
                upgrade.apply(shot);
        }
    }
}