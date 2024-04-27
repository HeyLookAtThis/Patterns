using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunsCreator : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Gun[] _prefabs;

    private List<Gun> _result = new List<Gun>();

    private UnityAction<Gun[]> _finished;

    public event UnityAction<Gun[]> Finished
    {
        add => _finished += value;
        remove => _finished -= value;
    }

    private void Start()
    {
        Run();
        _finished?.Invoke(_result.ToArray());
    }

    private void Run()
    {
        foreach (var gun in _prefabs)
        {
            Gun newGun = Instantiate(gun, this.transform);
            newGun.Initialize(_target);
            _result.Add(newGun);
        }
    }
}
