using UnityEngine;

[RequireComponent(typeof(Health))]
public class Enemy : MonoBehaviour
{
    public const string LAYER_NAME = "Enemy";
    [SerializeField] private float movespeed;
    [SerializeField] private Vector3 target;
    [SerializeField] private int bounty;
    public Health Health { get; private set; }

    // Start is called before the first frame update
    private void Start()
    {
        Health = GetComponent<Health>();
        Health.OnDeath += Die;
    }

    private void Die()
    {
        Shop.Gold += bounty;
        Destroy(gameObject);
    }

    // Update is called once per frame
    private void Update()
    {
        var step = movespeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            player.Health.TakeDamage(1);
            Destroy(gameObject);
        }
    }
}