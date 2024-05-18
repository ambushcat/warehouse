using UnityEngine;

public class TriggerLightIntensity : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    Light directionalLight;
    [SerializeField]
    float intensity;

    public void Trigger()
    {
        directionalLight.intensity = intensity;
    }
}
