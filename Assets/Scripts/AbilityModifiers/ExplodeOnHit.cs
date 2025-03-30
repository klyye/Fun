using UnityEngine;

public class ExplodeOnHit : MonoBehaviour
{
    public float radius = 1f;
    public int damage = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        var layerMask = 1 << LayerMask.NameToLayer(Enemy.LAYER_NAME);
        var enemies = Physics2D.CircleCastAll(transform.position, radius, transform.eulerAngles, 0, layerMask);
        // todo add explosion vfx
        foreach (var enemy in enemies)
        {
            var enemyComponent = enemy.transform.GetComponent<Enemy>();
            if (enemyComponent != null)
            {
                enemyComponent.Health.TakeDamage(damage);
            }
        }
    }
}