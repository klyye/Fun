using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "ShopItem", menuName = "ScriptableObjects/ShopItem")]
public class ShopItem : ScriptableObject
{
    public int cost;
    public UnityEvent onPurchase;
}