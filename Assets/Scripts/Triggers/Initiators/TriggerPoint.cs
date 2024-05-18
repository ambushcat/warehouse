using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    [SerializeField]
    public GameObject triggerObject;
    [SerializeField]
    public bool isColliderEnabled = true;
    [SerializeField]
    public GameObject initiator;
    private Objective objective;

    private void Start()
    {
        Objective x = gameObject.GetComponent<Objective>();
        objective = x;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (objective != null && !objective.shouldBeDone)
        {
            return;
        }

        if (isColliderEnabled)
        {
            if (collision.gameObject.tag == initiator.tag)
            {
                ITriggerableObject[] triggerComponents = triggerObject.GetComponents<ITriggerableObject>();
                foreach (var triggerComponent in triggerComponents)
                {
                    triggerComponent.Trigger();
                }
                isColliderEnabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (objective.shouldBeDone)
        {
            if (collider.gameObject.tag == initiator.tag)
            {
                ITriggerableObject[] triggerComponents = triggerObject.GetComponents<ITriggerableObject>();
                foreach (var triggerComponent in triggerComponents)
                {
                    triggerComponent.Trigger();
                }
            }
        }
    }
}
