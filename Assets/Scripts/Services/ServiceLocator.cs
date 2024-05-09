using UnityEngine;

namespace Assets.Scripts.Services
{
    [CreateAssetMenu(fileName = "ServiceLocatorConfig", menuName = "ScriptableObjects/ServiceLocator", order = 1)]
    public class ServiceLocator : ScriptableObject
    {
        public GameObject AudioManagerPrefab;
        public DataStorageManager DataStorageManager;
        private AudioManager audioManager;

        public AudioManager GetAudioManager()
        {
            if (audioManager == null)
            {
                GameObject audioManagerGameObject = Instantiate(AudioManagerPrefab);
                DontDestroyOnLoad(audioManagerGameObject);
                audioManager = audioManagerGameObject.GetComponent<AudioManager>();
            }
            return audioManager;

        }
        public DataStorageManager GetDataStorageManager() { return DataStorageManager; }
    }

}