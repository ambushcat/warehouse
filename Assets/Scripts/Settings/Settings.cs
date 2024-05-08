using Assets.Scripts.Services;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Settings
{
    public class Settings : MonoBehaviour
    {
        public Slider slider;
        public string mainMenuSceneName;
        public ServiceLocator serviceLoactor;

        private void Start()
        {
            slider.value = serviceLoactor.GetAudioManager().Volume;
        }

        public void SetVolume(float value)
        {
            serviceLoactor.GetAudioManager().Volume = value;
        }

        public void BackToMainMenu()
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }
}
