using UnityEngine;

namespace Assets.Scripts.Services
{
    [CreateAssetMenu(fileName = "DataStorageManagerConfig", menuName = "ScriptableObjects/DataStorageManager", order = 1)]
    public class DataStorageManager : ScriptableObject
    {
        public string volumeKey;
        public float Volume
        {
            get
            {
                return PlayerPrefs.GetFloat(volumeKey, 1);
            }
            set
            {
                PlayerPrefs.SetFloat(volumeKey, value);
            }
        }
    }

}
