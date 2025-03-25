using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int gold = 30;

    public static Player player;

    public static GameManager global { get; private set; }

    private void Awake()
    {
        if (global != null && global != this)
        {
            Destroy(gameObject);
        }
        else
        {
            global = this;
        }
        player = FindAnyObjectByType<Player>();
    }

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}