using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderPlayer : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    public void ChangeHealthBar(int health)
    {
        _healthBar.value = health;
    }
}
