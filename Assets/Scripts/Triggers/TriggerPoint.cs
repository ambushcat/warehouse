using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    [SerializeField]
    public GameObject triggerObject;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            ITriggerableObject triggerComponent = triggerObject.GetComponent<ITriggerableObject>();
            if (triggerComponent != null)
            {
                triggerComponent.Trigger();
            }
        }
    }
}
