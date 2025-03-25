using UnityEngine;

public class DeleteAfterDuration : MonoBehaviour
{
    [SerializeField] private float duration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        duration -= Time.deltaTime;
        if (duration <= 0) Destroy(gameObject);
    }
}
