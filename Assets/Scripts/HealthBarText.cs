using UnityEngine;
using TMPro;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthBarText;
    [SerializeField] private Health _health;

    private void Awake()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        string healthText = $"{health} / {_health.MaxValue}";

        _healthBarText.text = healthText;
    }
}
