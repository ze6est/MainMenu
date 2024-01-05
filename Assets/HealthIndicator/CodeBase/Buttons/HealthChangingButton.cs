using UnityEngine;
using UnityEngine.UI;

public class HealthChangingButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private PlayerHealth _health;

    [SerializeField] private int _healthCount;

    private void Awake() => 
        _button.onClick.AddListener(ChangeHealth);

    private void ChangeHealth() => 
        _health.ChangeHealth(_healthCount);
}