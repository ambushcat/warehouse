using UnityEngine;

public class TriggerText : MonoBehaviour, ITriggerableObject
{
    public GameObject textObject;
    public void Trigger()
    {
        if(textObject != null)
        {
            textObject.SetActive(true);
        }
    }
}
