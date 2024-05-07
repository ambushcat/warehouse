using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    public string sceneName;
    public void Trigger()
    {
       SceneManager.LoadScene(sceneName:sceneName);
    }
}
