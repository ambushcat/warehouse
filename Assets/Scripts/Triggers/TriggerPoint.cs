using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    [SerializeField]
    public GameObject triggerObject;
    [SerializeField]
    public bool isColliderEnabled = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (isColliderEnabled)
        {
            if (collision.gameObject.tag == "Ball")
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
}
