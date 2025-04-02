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
        var seen = new HashSet<int>();
        // generate 3 buttons
        for (var i = 0; i < 3; i++)
        {
            var index = Random.Range(0, upgrades.Count);

            while (seen.Contains(index))
            {
                index = Random.Range(0, upgrades.Count);
            }

            seen.Add(index);
            var upgrade = upgrades[index];
            var button = Instantiate(buttonPrefab, transform);
            // fill in button text
            var text = button.GetComponentInChildren<TMP_Text>();
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