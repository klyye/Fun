using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float lifetime;

    private void Awake()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.up * (Time.deltaTime * movespeed);
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
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


}