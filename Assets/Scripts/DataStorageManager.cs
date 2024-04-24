using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorageManager : MonoBehaviour
{
    private static readonly string VOLUME_KEY = "Volume";

    #region Singleton

    public static DataStorageManager Instance;

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

    public float Volume
    {
        get
        {
            return PlayerPrefs.GetFloat(VOLUME_KEY, 1);
        }
        set
        {
            PlayerPrefs.SetFloat(VOLUME_KEY, value);
        }
    }
}
