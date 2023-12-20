using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile proj;
    [SerializeField] private float interval;
    private float _timeUntilShot;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        _timeUntilShot -= Time.deltaTime;
        if (_timeUntilShot <= 0)
        {
            _timeUntilShot = interval;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(proj);
    }
}