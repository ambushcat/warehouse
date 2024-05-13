using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionMenu : MonoBehaviour
{
    public void LoadScene(string nextSceneName)
    {
        SceneManager.LoadSceneAsync(nextSceneName, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }

    public void RestartScene()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
}
