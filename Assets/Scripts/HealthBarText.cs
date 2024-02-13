using UnityEngine;
using TMPro;

public class HealthBarText : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthBarText;
    [SerializeField] private int _maxValue = 100;

    private void Awake()
    {
        HealthPlayer.HealthChanged += ChangeHealth;
    }

    private void ChangeHealth(int health)
    {
        _healthBarText.text = health.ToString() + "/" + _maxValue.ToString();
    }
}
