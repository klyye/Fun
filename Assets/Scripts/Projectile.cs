using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float duration;

    private void Awake()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.up * (Time.deltaTime * movespeed);
        duration -= Time.deltaTime;
        var untilNextSec = duration - (int)duration;
        if (duration <= 0)
        {
            Destroy(gameObject);
        }
        // Close to 1 second mark or 0.5 second mark
        else if (untilNextSec <= double.Epsilon ||
                 (untilNextSec - 0.5 > 0 && untilNextSec - 0.5 <= double.Epsilon))
        {
            var radius = 5f;
            // TODO: finish this
            var hitInfo = Physics2D.CircleCast(transform.position, radius, transform.eulerAngles);

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Health.TakeDamage(1);
            Destroy(gameObject);
        }
    }

// TODO: heat seeking missiles with https://docs.unity3d.com/ScriptReference/Physics.SphereCast.html
}