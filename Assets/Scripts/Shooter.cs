using System;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private StraightMovement proj;
    [SerializeField] private float interval;
    private readonly ISet<Action<StraightMovement>> _onHit = new HashSet<Action<StraightMovement>>();
    private readonly ISet<Action<StraightMovement>> _onSpawn = new HashSet<Action<StraightMovement>>();
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

    public void AddOnHitAction(Action<StraightMovement> action)
    {
        _onHit.Add(action);
    }

    public void AddOnSpawnAction(Action<StraightMovement> action)
    {
        _onSpawn.Add(action);
    }

    private void Shoot()
    {
        var shot = Instantiate(proj);
        foreach (var upgrade in _onSpawn) upgrade(shot);
    }
}