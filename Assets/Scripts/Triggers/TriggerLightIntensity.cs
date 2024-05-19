using UnityEngine;

public class TriggerLightIntensity : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    ReflectionProbe reflectionProbe;
    [SerializeField]
    float intensity;

    public void Trigger()
    {
        reflectionProbe.intensity = intensity;
    }
}
