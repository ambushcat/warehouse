using TMPro;
using UnityEngine;

public class ObjectiveSystem : MonoBehaviour
{
    [SerializeField]
    public Objective[] objectives;
    public TMP_Text text;
    private Objective currentObjective;
    public delegate void ObjectiveLocationChanged(Transform newLocation);
    public static event ObjectiveLocationChanged OnObjectiveLocationChanged;

    private void Start()
    {
        LoadObjectivesText();
    }

    public void CompleteObjective(Objective objective)
    {
        foreach (var obj in objectives)
        {
            if (currentObjective.name == objective.name)
            {
                obj.Complete();
                currentObjective = null;
                OnObjectiveLocationChanged?.Invoke(null);
                LoadObjectivesText();
            }
        }
    }

    void LoadObjectivesText()
    {
        FontStyles currentStyle = text.fontStyle;
        text.fontStyle = FontStyles.Bold;
        text.text = "OBJECTIVES: \n";
        text.fontStyle = currentStyle;


        foreach (var obj in objectives)
        {
            if (!obj.completed)
            {
                if (currentObjective == null)
                {
                    currentObjective = obj;
                    OnObjectiveLocationChanged?.Invoke(currentObjective.transform);
                    obj.SetActive();                    
                }
                text.text = text.text + obj.objectiveName + "\n";
            }
        }
    }
}
