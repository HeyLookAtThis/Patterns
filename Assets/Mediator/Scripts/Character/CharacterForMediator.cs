using System;
using UnityEngine;

public class CharacterForMediator : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private Health _health;
    private Level _level;

    private CharacterStatMediator _statMediator;

    public CharacterStatMediator StatMediator => _statMediator;

    private void Awake()
    {
        _health = new(_maxHealth);
        _level = new();
        _statMediator = new(_health, _level);
    }

    private void OnEnable()
    {
        _health.RanOut += OnReset;
    }

    private void OnDisable()
    {
        _health.RanOut -= OnReset;
    }

    public void RaiseLevel() => _level.Raise();

    public void TakeDamage(float damage) => _health.Reduce(damage);

    private void OnReset()
    {
        _health.Reset();
        _level.Reset();
    }
}
