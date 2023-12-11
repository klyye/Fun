using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile proj;
    [SerializeField] private float interval;
    private float _timeUntilShot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilShot -= Time.deltaTime;
        if (_timeUntilShot <= 0)
        {
            _timeUntilShot = interval;
            Shoot();
        }
    }

    void Shoot()
    {
        // just randomly shoots for now, can make targeting later
        Instantiate(proj);
        proj.transform.Rotate(0, 0, Random.Range(0f, 360f));
    }
}
