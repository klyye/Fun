using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float duration;

    private Transform target;

    private Transform SeekTarget(float radius, float dist, string layerName)
    {
        var tf = transform;
        var layerMask = 1 << LayerMask.NameToLayer(layerName);
        var hitInfo = Physics2D.CircleCast(
            tf.position, radius, tf.eulerAngles, dist, layerMask);
        return hitInfo.transform;
    }

    // Update is called once per frame
    private void Update()
    {
        if (target)
            transform.up = target.position - transform.position;
        else
            target = SeekTarget(13, 0, Enemy.LAYER_NAME);

        transform.position += transform.up * (Time.deltaTime * movespeed);
        duration -= Time.deltaTime;
        if (duration <= 0)
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

// TODO: heat seeking missiles with https://docs.unity3d.com/ScriptReference/Physics.SphereCast.html
}