using System.Linq;
using UnityEngine;

public class Magazine : MonoBehaviour
{
    [SerializeField, Range(1, 6)] private int _capacity;
    [SerializeField] private Transform _shotPlace;

    private Bullet[] _bullets;

    public bool IsEmpty => TryGetBullet() == null;

    public Bullet TryGetBullet()
    {
        return _bullets.FirstOrDefault(bullet => bullet.gameObject.activeSelf);
    }

    public void Reload()
    {
        foreach (var bullet in _bullets)
        {
            bullet.transform.position = transform.position;
            bullet.gameObject.SetActive(true);
        }
    }

    public void Initialize(Bullet bullet)
    {
        _bullets = new Bullet[_capacity];

        for (int i = 0; i < _capacity; i++)
            _bullets[i] = Instantiate(bullet, _shotPlace);
    }
}
