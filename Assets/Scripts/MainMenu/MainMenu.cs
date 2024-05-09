using Assets.Scripts.Services;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName;
    public string settingsSceneName;
    public ServiceLocator serviceLocator;

    private void Start()
    {
        serviceLocator.GetAudioManager().PlayBackgroundMusic();
    }

    public void Play()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player has quit");
    }
}
