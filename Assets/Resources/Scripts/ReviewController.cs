using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviewController : StudyingController
{
    public List<WrongWord> wrongWords = new List<WrongWord>(0);
    public void MakeWrongList()
    {
        for (int i = 0; i < wrongWords.Count; i++)
        {
            GameObject t = Instantiate(word);
            t.transform.SetParent(content.transform);
            WrongWord w = t.GetComponent<WrongWord>();
            w.SetWord(wrongWords[i].GetWord());
            w.SetMean(wrongWords[i].GetMean());
            w.SetWrongCount(wrongWords[i].GetWrongCount());
        }
    }

    public bool AddWrong(WrongWord w)
    {
        int index = wrongWords.FindIndex(item => item.GetWord().Equals(w.GetWord()));
        Debug.Log(index);
        if (index == -1)
        {
            wrongWords.Add(w);
            return true;
        }
        else
        {
            wrongWords[index].SetWrongCount(wrongWords[index].GetWrongCount() + 1);
            return false;
        }
    }

    public List<WrongWord> GetWrongList()
    {
        return wrongWords;
    }

    public void SetWrongList(List<WrongWord> w)
    {
        wrongWords = w;
    }
}
