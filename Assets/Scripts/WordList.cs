using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GuessWord
{
    public string word;
    public string translation;
}

[System.Serializable]
public class WordList
{
    public GuessWord[] list;
}
