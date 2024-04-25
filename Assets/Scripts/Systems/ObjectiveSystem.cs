using TMPro;
using UnityEngine;

public class ObjectiveSystem : MonoBehaviour
{
    [SerializeField]
    public Objective[] objectives;
    public TMP_Text text;

    void Update()
    {

        foreach (var obj in objectives)
        {
            if (obj.enabled)
            {
                obj.Blink();
            }
        }
    }

    private void Start()
    {
        LoadObjectivesText();
    }

    public void CompleteObjective(Objective objective)
    {
        foreach (var obj in objectives)
        {
            if (obj.name == objective.name)
            {
                obj.Complete();
                LoadObjectivesText();
            }
        }
    }

    void LoadObjectivesText()
    {
        text.text = "Objectives \n";
        foreach (var obj in objectives)
        {
            if (!obj.completed)
            {
                text.text = text.text + obj.objectiveName + "\n";
            }
        }
    }
}
