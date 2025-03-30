using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalOrVerticalLayoutGroup))]
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
            GameManager.gold -= upgrade.cost;
            GameManager.player.UpgradePlayer(upgrade);
        }

    }
}