using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class GoldText : MonoBehaviour
{
    [SerializeField] private Shop shop;
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        _text.text = "Gold: " + GameManager.gold;
    }
}