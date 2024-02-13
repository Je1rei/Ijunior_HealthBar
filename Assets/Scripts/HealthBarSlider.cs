using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private void Awake()
    {
        HealthPlayer.HealthChanged += ChangeHealth;
    }

    private void ChangeHealth(int health)
    {
        _healthBar.value = health;
    }
}
