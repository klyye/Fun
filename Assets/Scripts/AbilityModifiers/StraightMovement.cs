using UnityEngine;

public class StraightMovement : MonoBehaviour
{
    [SerializeField] private float movespeed;

    private void Awake()
    {
        transform.up = Random.insideUnitCircle;
    }

    // Update is called once per frame
    private void Update()
    {

        transform.position += transform.up * (Time.deltaTime * movespeed);
    }



}