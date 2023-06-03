using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
class EnemyCube : BaseEnemy, IHitable
{
    [SerializeField] private float _pushForce;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Hit(float damage, Transform hitSource)
    {
        Health -= damage;
        Vector3 direction = transform.position - hitSource.position;
        direction = direction.normalized;

        Vector3 force = direction * _pushForce;
        _rigidbody.AddForce(force, ForceMode.Impulse);
    }
}
