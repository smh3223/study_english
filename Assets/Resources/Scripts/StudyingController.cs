using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StudyingController : MonoBehaviour
{

    public GameObject word;
    public GameObject content;

    Word[] wordList = new Word[20];
    
    public void MakeWordList()
    {
        List<Dictionary<string, string>> data = Manager.instance.data;

        int range = (Manager.instance.user.GetLevel()-1) * 20;

        for (int i = 0; i < 20; i++)
        {
            GameObject t = Instantiate(word);
            t.transform.SetParent(content.transform);
            Word w = t.GetComponent<Word>();
            w.SetWord(data[range+i]["word"]);
            w.SetMean(data[range+i]["mean"]);

            wordList[i] = w;
            
        }
    }

    public Word[] GetWordList()
    {
        return wordList;
    }
    


}
