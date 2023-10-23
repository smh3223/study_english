using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Word : MonoBehaviour
{

    protected string word;
    protected string mean;

    public Text word_text;
    public Text mean_text;

    
    public void SetWord(string w)
    {
        word = w;
        word_text.text = w;
    }

    public void SetMean(string m)
    {
        mean = m;
        mean_text.text = m;
    }

    public string GetWord()
    {
        return word;
    }

    public string GetMean()
    {
        return mean;
    }
    
}
