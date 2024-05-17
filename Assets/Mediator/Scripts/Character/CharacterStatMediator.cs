using System;

public class CharacterStatMediator
{
    private Health _health;
    private Level _level;

    public CharacterStatMediator(Health health, Level level)
    {
        _health = health;
        _level = level;
    }

    public event Action<float> HealthChanged
    {
        add => _health.Changed += value;
        remove => _health.Changed -= value;
    }

    public event Action<int> LevelChanged
    {
        add => _level.Changed += value;
        remove => _level.Changed -= value;
    }
}
