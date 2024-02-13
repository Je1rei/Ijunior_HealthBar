using System;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _minHealth = 0;

    public static event Action<int> HealthChanged;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    public void TakeDamage(int damage)
    {
        if (_health > _minHealth)
        {
            _health -= damage;

            HealthChanged?.Invoke(_health);
        }
    }

    public void Heal(int value)
    {
        if (_health < _maxHealth)
        {
            _health += value;

            HealthChanged?.Invoke(_health);
        }
    }
}
