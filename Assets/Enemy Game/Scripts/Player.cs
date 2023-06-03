using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        Update1();
    }

    void Update1()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        Ray cameraToPoint = Camera.main.ScreenPointToRay(Input.mousePosition);
        bool hitSomethig = Physics.Raycast(cameraToPoint, out RaycastHit hitInfo, 100f);

        if (hitSomethig)
        {
            Collider collider = hitInfo.collider;
            IHitable hitable = collider.gameObject.GetComponent<IHitable>();

            if (hitable != null)
            {
                hitable.Hit(25f, transform);
            }
        }
    }
}

