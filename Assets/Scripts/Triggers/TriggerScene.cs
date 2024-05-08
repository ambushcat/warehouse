using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerActive : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    public  GameObject x;
    public void Trigger()
    {
       x.SetActive(true);
    }
}
