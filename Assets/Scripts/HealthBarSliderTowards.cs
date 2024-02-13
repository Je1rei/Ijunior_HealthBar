using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderTowards : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    [SerializeField] private float _speedFillBar = 10f;

    public void ChangeHealthBar(int currentHealth, int health)
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, health, _speedFillBar * Time.deltaTime);
    }
}
