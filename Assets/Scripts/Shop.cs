using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalOrVerticalLayoutGroup))]
public class Shop : MonoBehaviour
{
    // TODO: randomly generate some items to be in the shop
    [SerializeField] private Button buttonPrefab;
    [SerializeField] private List<Upgrade> upgrades;

    private void Awake()
    {
        // generate 3 buttons
        for (int i = 0; i < 3; i++)
        {
            // todo prevent duplicates
            var index = Random.Range(0, upgrades.Count);
            var upgrade = upgrades[index];
            var button = Instantiate(buttonPrefab, transform);
            // fill in button text
            var text = GetComponentInChildren<TMP_Text>();
            text.text = $"{upgrade.upgradeName} ${upgrade.cost}";
            // hook up button events
            button.onClick.AddListener(() => BuyUpgrade(upgrade));
        }
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