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
    /*
     * TODO: game mechanic ideas need to brainstorm more
     * - spawn enemies in waves
     * - player gets to decide the next wave out of 3 choices
     * - think of some actual gameplay that's not just buying upgrades
     * - statically place towers?
     * - GEM TD??? you can build your own trackss? (seems really hard)
     * - enemies only spawn from one side of the screen?
     * - make a main menu and a fail state and win state
     * - new types of enemies
     *   - some kind of slime that splits
     *   - healing enemy
     *   - boss enemy
     *   - enemies with elemental types
     *   - enemies with armor
     * THe vision:
     * you spawn in on a map. every round, you pick 1 of 3 types of enemy waves. then you get upgrades. rinse and repeat.
     * idea: placeable barriers?
     * kinda want to keep the number of towers low, like you get 1 per act or something
     * at start of act, place towers
     * instead of campfires, you get to reposition
     * or maybe the whole tower defense/roguelike this is not in service of the vision of "least time to fun"
     * keep it SIMPLE, like arcade game scope
     * what makes vampire survivors fun?
     * - the actual interaction is just moving around, not that fun, just gives you something to do
     * - seeing new upgrades and new enemies is novel
     * - the chaos of it all, tons of projectiles and enemies
     *
     * maybe just have your towers fire towards your mouse, or towards a placed reticle a la dartling gunner btd6
     */

    /**
     * TODO LIST WITH THE VISION:
     * When the game starts, place your first tower
     * Select your first big upgrade/weapon
     * Select the first wave
     * make the towers shoot towards the mouse
     * choose next upgrade, next wave, repeat
     * maybe make a boss, then after that you get two towers
     * powerups? pause? reposition?
     */
}