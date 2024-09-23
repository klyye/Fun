using UnityEngine;

public class Shop : MonoBehaviour
{
    // TODO: randomly generate some items to be in the shop
    /*
     * ideas:
     * exploding bullets -> on hit
     * poison/burn/dot -> on hit
     * bullet fractures into more bullets -> on hit
     * BIG bullet size -> on spawn
     * slow effect -> on hit
     * critical hits -> on hit
     * GMP/LMP -> on spawn
     * heat seeking -> while traveling
     * piercing shot -> on hit
     * double shot -> on spawn
     * spiral shot -> while traveling
     */

    private void Start()
    {
    }

    public void BuyUpgrade(Upgrade upgrade)
    {
        if (GameManager.gold >= upgrade.cost)
        {
            GameManager.gold -= upgrade.cost;
            Instantiate(upgrade, GameManager.player.transform);
        }

    }
}