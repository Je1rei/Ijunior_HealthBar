using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private int _maxValue = 100;
    [SerializeField] private int _minValue = 0;

    public event Action<int> Changed;

    public int MaxValue { get; private set; }

    private void Start()
    {
        MaxValue = _maxValue;
        Changed?.Invoke(_value);
    }

    public void TakeDamage(int damage)
    {
        _value -= damage;
        _value = Mathf.Clamp(_value, _minValue, MaxValue);
        Changed?.Invoke(_value);
    }

    public void Heal(int healValue)
    {
        _value += healValue;
        _value = Mathf.Clamp(_value, _minValue, MaxValue);
        Changed?.Invoke(_value);
    }
}
