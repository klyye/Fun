using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float lifetime;

    private void Awake()
    {
        StartCoroutine(DestroyAfterSeconds(lifetime));
    }

    IEnumerator DestroyAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * (Time.deltaTime * movespeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.health.TakeDamage(1);
            Destroy(gameObject);
        }
    }
}