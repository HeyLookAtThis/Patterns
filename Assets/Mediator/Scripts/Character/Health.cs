using System;

public class Health
{
    private float _maxValue;
    private float _minValue;
    private float _currentValue;

    private Action _ranOut;
    private Action<float> _changed;

    public Health(float maxValue)
    {
        _minValue = 0f;

        if(maxValue > _minValue)
            _maxValue = maxValue;

        _currentValue = _maxValue;
    }

    public event Action RanOut
    {
        add => _ranOut += value;
        remove => _ranOut -= value;
    }

    public event Action<float> Changed
    {
        add => _changed += value;
        remove => _changed -= value;
    }

    public void Reduce(float damage)
    {
        if (_currentValue <= damage)
        {
            _currentValue = _minValue;
            _ranOut?.Invoke();
        }
        else
        {
            _currentValue -= damage;
        }

        _changed?.Invoke(_currentValue);
    }

    public void Reset()
    {
        _currentValue = _maxValue;
        _changed?.Invoke(_currentValue);
    }
}
