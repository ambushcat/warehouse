using UnityEngine;

public class TriggerMovement : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    Transform targetPosition;
    [SerializeField]
    GameObject objectToMove;
    [SerializeField]
    float speed;

    private bool isTriggered = false;
    public void Trigger()
    {
        isTriggered = true;

    }
    private void Update()
    {
        if (isTriggered)
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, targetPosition.position, Time.deltaTime * speed);
            if(objectToMove.transform.position == targetPosition.position)
            {
                isTriggered=false;
            }
        }
    }
}
