using UnityEngine;
using TMPro;

public class HealthBarTextPlayer : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthBarText;

    public void ChangeHealthBar(int health, int maxHealth)
    {
        _healthBarText.text = health.ToString() + "/" + maxHealth.ToString();
    }
}
