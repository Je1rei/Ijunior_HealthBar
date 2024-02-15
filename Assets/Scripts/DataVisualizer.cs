using UnityEngine;

public abstract class DataVisualizer : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.Changed += OnHealthChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged(int health);
} 
