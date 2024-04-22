using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private Transform grabPoint;
    [SerializeField] private LayerMask pickupLayer;

    public float pickupDistance = 2f;

    private GrabbableObject grabbable;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (grabbable == null)
            {
                // Not carrying object
                if (Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit, pickupDistance))
                {
                    if (hit.transform.TryGetComponent(out GrabbableObject grabbable))
                    {
                        this.grabbable = grabbable;
                        grabbable.Grab(grabPoint);
                    }
                }
            }
            else
            {
                // Carrying object
                grabbable.Drop();
                grabbable = null;
            }

        }
    }
}
