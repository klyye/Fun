using UnityEngine;

public class DeleteOnHit: MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            Destroy(gameObject);
        }
    }

}