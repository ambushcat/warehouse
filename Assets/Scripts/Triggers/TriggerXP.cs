using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerXP : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    public GameObject manager;
    [SerializeField]
    public int xp;

    public void Trigger()
    {
        XPSystem x = manager.GetComponent<XPSystem>();
        x.AddXP(xp);
    }
}
