using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderTowards : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private float _speedFillBar = 1f;

    public void ChangeHealthBar(int currentHealth, int health)
    {
        _healthBar.value = Mathf.MoveTowards(currentHealth, health, _speedFillBar * Time.deltaTime);
    }
}
