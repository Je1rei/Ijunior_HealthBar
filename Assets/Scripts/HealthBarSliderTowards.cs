using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSliderTowards : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _speedFillBar = 10f;

    private void Awake()
    {
        HealthPlayer.HealthChanged += ChangeHealth;
    }

    private IEnumerator SmoothFillBar(int health)
    {
        while (_healthBar.value != health)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, health, _speedFillBar * Time.deltaTime);
            yield return null;
        }
    }

    private void ChangeHealth(int health)
    {
        StartCoroutine(SmoothFillBar(health));
    }
}
