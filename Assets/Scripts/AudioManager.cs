using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    #region Singleton

    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    #endregion

    public AudioSource audioSource;

    public AudioClip mainMenuMusic;

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
            DataStorageManager.Instance.Volume = value;
        }
    }

    void Start()
    {
        Volume = DataStorageManager.Instance.Volume;
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
}
