using UnityEngine;

// todo: refactor; split into movement and damage/onhit components so you can swap out movement for heatseeking
public class StraightMovement : MonoBehaviour
{
    [SerializeField] private float movespeed;

    private void Awake()
    {
        transform.up = Random.insideUnitCircle;
        // TODO: THIS DOESNT WORK, HEATSEEKING ISNT SET UNTIL AFTER AWAKE
        // if (heatSeeking) _target = SeekTarget(4, 0, Enemy.LAYER_NAME);
    }

    // Update is called once per frame
    private void Update()
    {
        // if (_target) transform.up = _target.position - transform.position;

        transform.position += transform.up * (Time.deltaTime * movespeed);
    }


    private Transform SeekTarget(float radius, float dist, string layerName)
    {
        var tf = transform;
        var layerMask = 1 << LayerMask.NameToLayer(layerName);
        var hitInfo = Physics2D.CircleCast(
            tf.position, radius, tf.eulerAngles, dist, layerMask);
        return hitInfo.transform;
    }
}