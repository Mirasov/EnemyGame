using UnityEngine;

public class MagnetField : MonoBehaviour
{
    [SerializeField] private float _radius;

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);
        if(colliders.Length == 0)
        {
            return;
        }

        foreach(Collider collider in colliders)
        {
            IMagnetInteractable interactable = collider.GetComponent<IMagnetInteractable>();
            if(interactable == null)
            {
                continue;
            }

            interactable.Interact(transform);
        }
    }
}
