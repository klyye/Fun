using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private float interval;
    [SerializeField] private GameObject spawnee;
    private float _spawnZoneTop, _spawnZoneBottom;
    private float _timeUntilSpawn;

    private void Awake()
    {
        var rectTransform = GetComponent<RectTransform>();
        var corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);
        _spawnZoneBottom = corners[0].y;
        _spawnZoneTop = corners[2].y;
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
            var spawnY = Random.Range(_spawnZoneBottom, _spawnZoneTop);
            var spawnX = transform.position.x;
            Spawn(new Vector3(spawnX, spawnY));
            _timeUntilSpawn = interval;
        }
    }

    private void Spawn(Vector3 position)
    {
        Instantiate(spawnee, position, Quaternion.identity);
    }
}