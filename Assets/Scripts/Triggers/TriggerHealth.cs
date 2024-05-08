using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHealth : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    public GameObject manager;
    [SerializeField]
    public int healthChange;

    public void Trigger()
    {
        HealthSystem x = manager.GetComponent<HealthSystem>();
        if(healthChange < 0)
        {
            x.Damage(healthChange * -1);
        }
        if(healthChange > 0)
        {
            x.Heal(healthChange);
        }
    }
}
