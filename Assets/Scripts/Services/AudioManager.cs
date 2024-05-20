using UnityEngine;

namespace Assets.Scripts.Services
{
    public class AudioManager : MonoBehaviour
    {
        public ServiceLocator ServiceLocator;

        public AudioSource audioSource;

        public AudioClip mainMenuMusic;
        public AudioClip objectiveCompleted;

        private bool isMusicPlaying;

        public float Volume
        {
            get
            {
                return audioSource.volume;
            }
            set
            {
                audioSource.volume = value;
                ServiceLocator.GetDataStorageManager().Volume = value;
            }
        }

        private void Start()
        {
            Volume = ServiceLocator.GetDataStorageManager().Volume;
        }

        public void PlayBackgroundMusic()
        {
            if (!isMusicPlaying)
            {
                audioSource.clip = mainMenuMusic;
                audioSource.Play();
                isMusicPlaying = true;
                Debug.Log("Started background music");
            }

        }

        public void PlayObjectiveCompleted()
        {
            audioSource.PlayOneShot(objectiveCompleted);
        }
    }
}
