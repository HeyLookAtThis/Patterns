using UnityEngine;
using UnityEngine.Events;

public class Storage : MonoBehaviour
{
    [SerializeField] private StorageConfig _storageConfig;

    private float _currentItemCount;

    private UnityAction _emptied;
    private UnityAction _fulled;

    public event UnityAction Emptied
    {
        add => _emptied += value;
        remove => _emptied -= value;
    }

    public event UnityAction Fulled
    {
        add => _fulled += value;
        remove => _fulled -= value;
    }

    public void AddItem()
    {
        if(_currentItemCount < _storageConfig.CapacityConfig.MaxValue)
        {
            _currentItemCount += Time.deltaTime;
            Debug.Log("Работаю");
        }
        else
        {
            _currentItemCount = _storageConfig.CapacityConfig.MaxValue;
            _fulled?.Invoke();
        }
    }

    public void RemoveItem()
    {
        if (_currentItemCount > _storageConfig.CapacityConfig.MinValue)
        {
            _currentItemCount -= Time.deltaTime;
            Debug.Log("Отдыхаю, жи есть");
        }
        else
        {
            _currentItemCount = _storageConfig.CapacityConfig.MinValue;
            _emptied?.Invoke();
        }
    }
}
