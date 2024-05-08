using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroyObject : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    GameObject objectToDestroy;
    public void Trigger()
    {
        objectToDestroy.SetActive(false);
    }
}
