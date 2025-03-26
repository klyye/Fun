using UnityEngine;

public class Shop : MonoBehaviour
{
    // TODO: randomly generate some items to be in the shop

    private void Start()
    {
    }

    public void BuyUpgrade(Upgrade upgrade)
    {
        if (GameManager.gold >= upgrade.cost)
        {
            // TODO: disable duplicate upgrades
            GameManager.gold -= upgrade.cost;
            Instantiate(upgrade, GameManager.player.transform);
        }

    }
}