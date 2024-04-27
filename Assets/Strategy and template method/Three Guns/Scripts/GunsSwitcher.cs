using UnityEngine;

public class GunsSwitcher : MonoBehaviour
{
    private GunsCreator _creator;

    private Gun[] _guns;

    private int _currentGunIndex;

    private void Awake()
    {
        _creator = GetComponent<GunsCreator>();
    }

    private void OnEnable()
    {
        _creator.Finished += OnInitialize;
    }

    private void OnDisable()
    {
        _creator.Finished -= OnInitialize;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _currentGunIndex = GetNextIndex();
            Run();
        }
    }

    private void OnInitialize(Gun[] guns)
    {
        _currentGunIndex = 0;
        _guns = guns;
        Run();
    }

    private int GetNextIndex()
    {
        int index = _currentGunIndex;

        for (int i = 0; i < _guns.Length; i++)
        {
            if (i == _currentGunIndex)
            {
                index++;

                if (index == _guns.Length)
                    index = 0;
            }
        }

        return index;
    }

    private void Run()
    {
        for (int i = 0; i < _guns.Length; i++)
            _guns[i].gameObject.SetActive(false);

        _guns[_currentGunIndex].gameObject.SetActive(true);
    }
}
