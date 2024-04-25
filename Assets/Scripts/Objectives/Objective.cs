using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    [SerializeField]
    public string objectiveName;

    [SerializeField]
    public bool completed = false;

    [SerializeField]
    public bool active = false;


    public void Complete()
    {
        completed = true;
        active = false;
    }

    public void SetActive()
    {
        active = true;
    }



    private void Start()
    {
        StartCoroutine("Blink");
    }

    public void Blink()
    {
        if (active)
        {
            Color lerpColorRed = Color.Lerp(Color.white, Color.red, Time.time);
            gameObject.GetComponent<MeshRenderer>().material.color = lerpColorRed;
        } else
        {
            Color lerpColorWhite = Color.Lerp(Color.red, Color.white, Time.time);
            gameObject.GetComponent<MeshRenderer>().material.color = lerpColorWhite;
        }
    }
}
