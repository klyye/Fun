using System;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int startingHealth;
    [SerializeField] private Slider slider;

    private int _health;

    private void Awake()
    {
        _health = startingHealth;
        slider.maxValue = startingHealth;
        slider.value = _health;
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public event Action OnDeath;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        slider.value = _health;
        if (_health <= 0) OnDeath?.Invoke();
    }
}