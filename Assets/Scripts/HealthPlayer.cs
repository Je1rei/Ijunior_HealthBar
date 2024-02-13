using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthBarTextPlayer), typeof(HealthBarSliderPlayer), typeof(HealthBarSliderTowards))]
public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private HealthBarTextPlayer _healthBarTextPlayer;
    [SerializeField] private HealthBarSliderPlayer _healthBarSliderPlayer;
    [SerializeField] private HealthBarSliderTowards _healthBarSliderTowards;
    
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;

    private int _currentHealth;

    public int Health { get; private set; }

    private void Awake()
    {
        Health = _health;
        _currentHealth = Health;

        HealthBarsChange();
    }

    private void Update()
    {
        _healthBarSliderTowards.ChangeHealthBar(_currentHealth, Health);
    }

    public void TakeDamage(int damage)
    {
        _currentHealth = Health;
        Health -= damage;

        HealthBarsChange();
    }

    public void Heal(int value)
    {
        _currentHealth = Health;
        Health += value;

        HealthBarsChange();
    }

    private void HealthBarsChange()
    {
        _healthBarTextPlayer.ChangeHealthBar(Health, _maxHealth);

        _healthBarSliderPlayer.ChangeHealthBar(Health);
    }
}
