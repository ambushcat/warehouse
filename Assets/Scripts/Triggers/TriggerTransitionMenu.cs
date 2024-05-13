using MBS.View.Input.Physical;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerActive : MonoBehaviour, ITriggerableObject
{
    [SerializeField]
    public GameObject transitionMenu;
    [SerializeField]
    public FirstPersonController firstPersonController;
    public void Trigger()
    {
        Time.timeScale = 0f;
        transitionMenu.SetActive(true);
        firstPersonController.lockCursor = false;
        firstPersonController.mouseSensitivity = 0f;
        Cursor.lockState = CursorLockMode.None;
    }
}
