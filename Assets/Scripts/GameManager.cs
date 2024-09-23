using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int gold = 10;

    public static Player player;

    public static GameManager global { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        if (global != null && global != this)
        {
            Destroy(gameObject);
        }
        else
        {
            global = this;
            player = FindObjectOfType<Player>();
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}