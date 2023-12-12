using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private float interval;
    [SerializeField] private GameObject spawnee;
    private float spawnZoneTop, spawnZoneBottom;
    private float _timeUntilSpawn;

    private void Awake()
    {
        var rectTransform = GetComponent<RectTransform>();
        var corners = new Vector3[4];
        rectTransform.GetWorldCorners(corners);
        spawnZoneBottom = corners[0].y;
        spawnZoneTop = corners[2].y;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;
        if (_timeUntilSpawn <= 0)
        {
            var spawnY = UnityEngine.Random.Range(spawnZoneBottom, spawnZoneTop);
            var spawnX = transform.position.x;
            Spawn(new Vector3(spawnX, spawnY));
            _timeUntilSpawn = interval;
        }
    }

    void Spawn(Vector3 position)
    {
        Instantiate(spawnee, position, Quaternion.identity);
    }
}