using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int gold = 10;

    public static Player player;

    public static GameManager global => _instance;

    private static GameManager _instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            player = FindObjectOfType<Player>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
