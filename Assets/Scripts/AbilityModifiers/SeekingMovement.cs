using UnityEngine;

public class SeekingMovement : MonoBehaviour
{
    private Transform _target;
    public float refreshDuration;

    private float _interval;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _target = SeekTarget(4, 0, Enemy.LAYER_NAME);
        _interval = refreshDuration;
    }

    private Transform SeekTarget(float radius, float dist, string layerName)
    {
        var tf = transform;
        var layerMask = 1 << LayerMask.NameToLayer(layerName);
        var hitInfo = Physics2D.CircleCast(
            tf.position, radius, tf.eulerAngles, dist, layerMask);
        return hitInfo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _interval -= Time.deltaTime;
        if (_interval < 0)
        {
            _target = SeekTarget(4, 0, Enemy.LAYER_NAME);
            _interval = refreshDuration;
        }

        if (_target) transform.up = _target.position - transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            _target = null;
            _interval = refreshDuration;
        }
    }
}