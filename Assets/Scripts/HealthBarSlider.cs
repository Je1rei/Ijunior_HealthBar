using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Health _health;

    private void Awake()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        _healthBar.value = health;
    }
}
