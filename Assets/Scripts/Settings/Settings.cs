using Assets.Scripts.Services;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Settings
{
    public class Settings : MonoBehaviour
    {
        [SerializeField] Slider slider;
        public string mainMenuSceneName;
        public ServiceLocator serviceLoactor;

        private void Start()
        {
            slider.value = serviceLoactor.GetAudioManager().Volume;
        }

        private void save()
        {
            PlayerPrefs.SetFloat("Volume", slider.value);
        }

        public void SetVolume(float value)
        {
            slider.value = value;
            serviceLoactor.GetAudioManager().Volume = value;
            save();
        }

        public void BackToMainMenu()
        {
            SceneManager.LoadScene(mainMenuSceneName);
        }
        
    }
}
