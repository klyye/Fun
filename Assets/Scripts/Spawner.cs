using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private float interval;
    [SerializeField] private Enemy spawnee;
    private Vector3[] _spawnBoxCorners;
    private float _timeUntilSpawn;

    private void Awake()
    {
        var rectTransform = GetComponent<RectTransform>();
        _spawnBoxCorners = new Vector3[4];
        rectTransform.GetWorldCorners(_spawnBoxCorners);
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;
        if (_timeUntilSpawn <= 0)
        {
            var spawnY = Random.Range(_spawnBoxCorners[0].y, _spawnBoxCorners[2].y);
            var spawnX = Random.Range(_spawnBoxCorners[0].x, _spawnBoxCorners[2].x);
            Spawn(new Vector3(spawnX, spawnY));
            _timeUntilSpawn = interval;
        }
    }

    private void Spawn(Vector3 position)
    {
        Instantiate(spawnee, position, Quaternion.identity);
    }
}