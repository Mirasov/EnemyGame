using UnityEngine;

public class InteractableUnitBase : MonoBehaviour
{
    // Дистанция взаимодействия
    [SerializeField] protected float _pushDistance;

    // Сила взаимодействия
    [SerializeField] protected float _pushForce;
}