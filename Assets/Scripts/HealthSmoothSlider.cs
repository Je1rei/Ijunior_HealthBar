using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothSlider : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Health _health;

    [SerializeField] private float _speedFillBar = 10f;

    private Coroutine _currentCoroutine;

    private void Awake()
    {
        _health.Changed += OnHealthChanged;
    }

    private IEnumerator SmoothFillBar(int targetValue)
    {
        while (_healthBar.value != targetValue)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, targetValue, _speedFillBar * Time.deltaTime);
            yield return null;
        }
    }

    private void OnHealthChanged(int health)
    {
        if(_currentCoroutine != null)
        {
            StopCoroutine(_currentCoroutine);
        }

        _currentCoroutine = StartCoroutine(SmoothFillBar(health));
    }
}
