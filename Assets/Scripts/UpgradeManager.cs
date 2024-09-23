using UnityEngine;

/**
 * This class is necessary because the ShopItem ScriptableObject cannot reference scene data, so there must be a
 * prefab for it to call functions on.
 */
public class UpgradeManager : MonoBehaviour
{
    public void DoubleShotUpgrade()
    {
        var shooter = GameManager.player.GetComponent<Shooter>();
    }
}