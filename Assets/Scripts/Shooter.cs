using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile proj;
    [SerializeField] private float interval;
    private float _shotTimer;
    private ISet<Upgrade> upgrades = new HashSet<Upgrade>();
    public bool doubleShot;
    public bool heatSeekingShot;
    public bool piercingShot;
    public bool bigShot;

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
            Shoot();
        }
    }

    private void SpawnProjectile()
    {
        var shot = Instantiate(proj);
        // TODO LOOP THROUGH ALL PROJ UPGRADES
        shot.heatSeeking = heatSeekingShot;
        shot.piercing = piercingShot;

    }

    private void Shoot()
    {
        SpawnProjectile();
        // TODO FIND SOME WAY TO NOT USE A BUNCH OF BOOLS
        if (doubleShot)
        {
            Invoke(nameof(SpawnProjectile), 0.1f);
        }
    }
}