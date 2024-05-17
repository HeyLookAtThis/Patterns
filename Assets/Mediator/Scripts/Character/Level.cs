using System;

public class Level
{
    private int _initialValue;
    private int _currentValue;

    private Action<int> _changed;

    public Level()
    {
        _initialValue = 1;
        _currentValue = _initialValue;
    }

    public event Action<int> Changed
    {
        add => _changed += value;
        remove => _changed -= value;
    }

    public void Raise() => _changed?.Invoke(++_currentValue);

    public void Reset()
    {
        _currentValue = _initialValue;
        _changed?.Invoke(_currentValue);
    }
}
