using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class GoldText : MonoBehaviour
{
    private TMP_Text _text;
    [SerializeField] private Shop shop;
    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Gold: " + GlobalVars.gold;
    }
}
