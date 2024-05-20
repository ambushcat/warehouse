using UnityEngine;

public class MoveInstantly : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    Transform targetPosition;
    [SerializeField]
    GameObject objectToMove;

    public void Trigger()
    {
        // Instantly move the object to the target position and rotation
        objectToMove.transform.position = targetPosition.position;
        objectToMove.transform.rotation = targetPosition.rotation;
    }
}
