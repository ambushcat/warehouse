using UnityEngine;
using UnityEngine.UI;

public class TriggerBloodEffect : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    Image bloodImage; // Reference to the Image component for the blood effect
    [SerializeField]
    float displayDuration = 1f; // Duration the blood effect will stay on screen
    [SerializeField]
    float fadeDuration = 0.5f; // Duration it takes for the blood effect to fade out

    private bool isTriggered = false;
    private float timer = 0f;

    private void Update()
    {
        if (isTriggered)
        {
            timer += Time.deltaTime;
            if (timer >= displayDuration)
            {
                // Start fading out the blood effect
                float fadeProgress = (timer - displayDuration) / fadeDuration;
                bloodImage.color = new Color(bloodImage.color.r, bloodImage.color.g, bloodImage.color.b, 1 - fadeProgress);

                if (fadeProgress >= 1)
                {
                    isTriggered = false;
                    bloodImage.enabled = false; // Hide the image after fading out
                }
            }
        }
    }

    public void Trigger()
    {
        isTriggered = true;
        timer = 0f;
        bloodImage.enabled = true; // Show the image
        bloodImage.color = new Color(bloodImage.color.r, bloodImage.color.g, bloodImage.color.b, 1); // Fully visible
    }
}
