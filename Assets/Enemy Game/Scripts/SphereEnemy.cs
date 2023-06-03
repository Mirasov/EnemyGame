using UnityEngine;

class SphereEnemy : BaseEnemy, IHitable
{
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Hit(float damage, Transform hitSource)
    {
        Health -= damage;
        _meshRenderer.material.color = Color.red;
    }
}