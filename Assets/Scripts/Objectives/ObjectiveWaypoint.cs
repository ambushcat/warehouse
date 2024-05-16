using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
public class ObjectiveWaypoint : MonoBehaviour
{
    public Image img;
    public TMP_Text meter;
    public Transform target;

    void Start()
    {
        ObjectiveSystem.OnObjectiveLocationChanged += UpdateWaypointLocation;
    }

    void UpdateWaypointLocation(Transform x)
    {
        if (x != null)
        {
            target = x;
        }
    }

    void OnDestroy()
    {
        ObjectiveSystem.OnObjectiveLocationChanged -= UpdateWaypointLocation;
    }

    void Update()
    {
        float minX = img.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = img.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(target.position);

        if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        {
            if (pos.x < Screen.width / 2)
            {
                pos.x = maxX;
            }
            else
            {
                pos.x = minX;
            }
        }

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y + 50, minY, maxY);

        img.transform.position = pos;
        meter.text = ((int)Vector3.Distance(target.position, transform.position)).ToString() + "m";
    }
}
