using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private float duration;
    [SerializeField] private int damage;
    public bool heatSeeking;
    public bool piercing;

    private Transform _target;

    public bool IsClone { get; }

    private void Awake()
    {
        transform.up = Random.insideUnitCircle;
        // TODO THIS DOESNT WORK, HEATSEEKING ISNT SET UNTIL AFTER AWAKE
        if (heatSeeking) _target = SeekTarget(4, 0, Enemy.LAYER_NAME);
    }

    // Update is called once per frame
    private void Update()
    {
        if (_target) transform.up = _target.position - transform.position;

        transform.position += transform.up * (Time.deltaTime * movespeed);
        duration -= Time.deltaTime;
        if (duration <= 0) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Health.TakeDamage(damage);
            if (piercing)
                _target = null;
            // heatSeeking = false;
            else
                Destroy(gameObject);
        }
    }

    private Transform SeekTarget(float radius, float dist, string layerName)
    {
        var tf = transform;
        var layerMask = 1 << LayerMask.NameToLayer(layerName);
        var hitInfo = Physics2D.CircleCast(
            tf.position, radius, tf.eulerAngles, dist, layerMask);
        return hitInfo.transform;
    }
}