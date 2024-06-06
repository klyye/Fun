using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Projectile proj;
    [SerializeField] private float interval;
    private float _shotTimer;
    public bool doubleShot;
    public bool heatSeekingShot;
    public bool piercingShot;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        _shotTimer -= Time.deltaTime;
        if (_shotTimer <= 0)
        {
            _shotTimer = interval;
            Shoot();
            if (doubleShot)
            {
                Invoke(nameof(Shoot), 0.1f);
            }
        }
    }

    private void Shoot()
    {
        var shot = Instantiate(proj);
        shot.heatSeeking = heatSeekingShot;
    }

}