using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{    
    [SerializeField] private int _max = 5;

    [SerializeField] private int _current;

    public int Max => _max;

    public event UnityAction<int> HealthChanged;

    private void Start()
    {
        _current = _max;

        HealthChanged?.Invoke(_current);
    }

    public void ChangeHealth(int health)
    {
        if (_current <= 0)
        {
            _current = 0;
            HealthChanged?.Invoke(_current);
            return;
        }

        if (_current > _max)
        {
            _current = _max;
            HealthChanged?.Invoke(_current);
            return;
        }

        if (_current == _max && health > 0)
            return;

        _current += health;

        HealthChanged?.Invoke(_current);
    }
}