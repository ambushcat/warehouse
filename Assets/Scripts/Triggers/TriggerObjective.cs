using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjective : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    public Objective objective;
    [SerializeField]
    public ObjectiveSystem objectiveSystem;
    public void Trigger()
    {
       objectiveSystem.CompleteObjective(objective);
    }
}
