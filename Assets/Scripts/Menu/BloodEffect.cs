using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodEffect : MonoBehaviour
{
    [SerializeField]
    private Image bloodImage; // Reference to the Image component for the blood effect

    private void Start()
    {
        // Initialize the bloodImage to be invisible
        bloodImage.color = new Color(bloodImage.color.r, bloodImage.color.g, bloodImage.color.b, 0);
        bloodImage.enabled = false;
    }

}
