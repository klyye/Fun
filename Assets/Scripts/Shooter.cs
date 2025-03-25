using System;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject proj;
    [SerializeField] private float interval;
    private readonly ISet<Action<GameObject>> _onHit = new HashSet<Action<GameObject>>();
    private readonly ISet<Action<GameObject>> _onSpawn = new HashSet<Action<GameObject>>();
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

    public void AddOnHitAction(Action<GameObject> action)
    {
        _onHit.Add(action);
    }

    public void AddOnSpawnAction(Action<GameObject> action)
    {
        _onSpawn.Add(action);
    }

    private void Shoot()
    {
        var shot = Instantiate(proj);
        foreach (var upgrade in _onSpawn) upgrade(shot);
    }
}