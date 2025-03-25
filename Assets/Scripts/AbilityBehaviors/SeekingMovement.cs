using UnityEngine;

public class SeekingMovement : MonoBehaviour
{
    private Transform _target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _target = SeekTarget(4, 0, Enemy.LAYER_NAME);
    }

    private Transform SeekTarget(float radius, float dist, string layerName)
    {
        var tf = transform;
        var layerMask = 1 << LayerMask.NameToLayer(layerName);
        var hitInfo = Physics2D.CircleCast(
            tf.position, radius, tf.eulerAngles, dist, layerMask);
        return hitInfo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_target) transform.up = _target.position - transform.position;
    }
}