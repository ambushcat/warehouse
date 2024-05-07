using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;

public class PageBuilder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Parse the JSON data
        List<string> wordList = JsonConvert.DeserializeObject<List<string>>(JSONUtility.instance.wordlists[0].ToString());

        // Loop through the word list
        foreach (string word in wordList)
        {
            int index = wordList.IndexOf(word) + 1;
            // Set the text of the TextMesh
            gameObject.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().text +=  index + ". " + word + '\n';

            // Parent the TextMesh to the paper GameObject
            gameObject.transform.parent = gameObject.transform;
        }
    }
}
