using UnityEngine;

public class TriggerMovement : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    Transform targetPosition;
    private bool isTriggered;
    public void Trigger()
    {
        isTriggered = true;

    }
    private void Update()
    {
        if (isTriggered)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, Time.deltaTime);
        }
    }
}
