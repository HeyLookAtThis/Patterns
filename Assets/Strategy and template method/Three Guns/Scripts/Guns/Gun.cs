using UnityEngine;

[RequireComponent(typeof(Magazine))]
public abstract class Gun : MonoBehaviour
{
    [SerializeField] private Transform _shotPlace;
    [SerializeField] private Bullet _bullet;

    protected Magazine magazine;

    private Target _target;

    private void OnEnable()
    {
        if (_target != null)
            _target.Clicked += OnTryShot;
    }

    private void OnDisable()
    {
        _target.Clicked -= OnTryShot;
    }

    public void Initialize(Target target)
    {
        _target = target;
        _target.Clicked += OnTryShot;

        magazine = GetComponent<Magazine>();
        magazine.Initialize(_bullet);
    }

    protected virtual void OnTryShot()
    {
        magazine.TryGetBullet()?.SetFlying();
    }
}
