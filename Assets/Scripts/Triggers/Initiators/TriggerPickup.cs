using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject triggerObject;
    [SerializeField]
    public GameObject grabbableObject;
    private Objective objective;

    private void Start()
    {
        Objective x = gameObject.GetComponent<Objective>();
        objective = x;
    }
    private void Update()
    {
        if (objective.shouldBeDone)
        {
            GrabbableObject x = grabbableObject.GetComponent<GrabbableObject>();
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
}
