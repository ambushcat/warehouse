using System.Collections;
using UnityEngine;

public class TriggerLightIntensity : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    Light directionalLight;
    [SerializeField]
    float targetIntensity;
    [SerializeField]
    float duration = 1.0f; // Duration over which to change the intensity

    private Coroutine intensityCoroutine;

    public void Trigger()
    {
        if (intensityCoroutine != null)
        {
            StopCoroutine(intensityCoroutine);
        }
        intensityCoroutine = StartCoroutine(ChangeIntensityOverTime(directionalLight.intensity, targetIntensity, duration));
    }

    private IEnumerator ChangeIntensityOverTime(float startIntensity, float endIntensity, float duration)
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            directionalLight.intensity = Mathf.Lerp(startIntensity, endIntensity, elapsed / duration);
            yield return null;
        }

        // Ensure the final value is set after the loop
        directionalLight.intensity = endIntensity;
    }
}
