using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IMagnetInteractable interactable = other.GetComponent<IMagnetInteractable>();
        if(interactable == null)
        {
            return;
        }

        interactable.StopInteract();
    }
}
