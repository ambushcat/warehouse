using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

public class JSONUtility : MonoBehaviour
{
    [SerializeField] public TextAsset[] wordlists;
    [SerializeField] private GameObject[] wordAssetPrefabs;

    private Dictionary<string, GameObject> wordAssetMap;

    public static JSONUtility instance;

    private void Awake()
    {
        wordAssetMap = new Dictionary<string, GameObject>();
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(instance);
        } else {
            Destroy(gameObject);
        }
        //BuildWordAssetMap();
    }

    private void BuildWordAssetMap()
    {
        if (wordlists.Length != wordAssetPrefabs.Length) 
        {
            Debug.LogError(" Number of word lists and assets is incorrect");
            
        }

        for (int i = 0; i < wordlists.Length; i++)
        {
            List<GuessWord> wordDataList = ParseWordList(wordlists[i].text);
            foreach (GuessWord data in wordDataList)
            {
                wordAssetMap.Add(data.translation, wordAssetPrefabs[i]);
            }
        }
    }

    private List<GuessWord> ParseWordList(string jsonString)
    {
        WordList wordDataList = JsonUtility.FromJson<WordList>(jsonString);
        return wordDataList.list.ToList();
    }

    public GameObject GetWordAsset(string word)
    {
        if (wordAssetMap.ContainsKey(word))
        {
            return wordAssetMap[word];
        }
        else
        {
            Debug.LogError("Word '" + word + "' not found in word list!");
            return null;
        }
    }
}
