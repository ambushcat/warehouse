using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivateObject : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    GameObject objectToActivate;
    public void Trigger()
    {
        objectToActivate.SetActive(true);
    }
}
