using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private bool _isFlying;
    private float _speed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _speed = 1500f;
    }

    private void Update()
    {
        if (_isFlying)
            _rigidbody.velocity = _speed * Time.deltaTime * Vector3.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Target>(out Target target))
        {
            _isFlying = false;
            this.gameObject.SetActive(false);
        }
    }

    public void SetFlying() => _isFlying = true;
}
