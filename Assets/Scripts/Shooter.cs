using System;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile proj;
    [SerializeField] private float interval;
    private readonly ISet<Action<Projectile>> _onHit = new HashSet<Action<Projectile>>();
    private readonly ISet<Action<Projectile>> _onSpawn = new HashSet<Action<Projectile>>();
    private float _shotTimer;

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

    public void AddOnHitAction(Action<Projectile> action)
    {
        _onHit.Add(action);
    }

    public void AddOnSpawnAction(Action<Projectile> action)
    {
        _onSpawn.Add(action);
    }

    private void Shoot()
    {
        var shot = Instantiate(proj);
        foreach (var upgrade in _onSpawn) upgrade(shot);
    }
}