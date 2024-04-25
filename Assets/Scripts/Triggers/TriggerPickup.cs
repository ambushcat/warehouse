using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject triggerObject;
    private void Update()
    {

        GrabbableObject x = gameObject.GetComponent<GrabbableObject>();
        if (x)
        {
            if (x.isBeingGrabbed())
            {
                ITriggerableObject[] triggerComponents = triggerObject.GetComponents<ITriggerableObject>();
                foreach (var triggerComponent in triggerComponents)
                {
                    triggerComponent.Trigger();
                }
            }
        };
    }
}
