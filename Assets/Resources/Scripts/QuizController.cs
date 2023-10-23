using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizController : MonoBehaviour
{
    public GameObject word;
    Quiz[] quizzes = new Quiz[10];
    List<string> ls = new List<string>();
    int result = 0;
    
    public void MakeQuiz()
    {
        for (int i = 0; i < 10;)
        {
            quizzes[i] = new Quiz();
            quizzes[i].CreateQuiz();

            if (ls.Contains(quizzes[i].GetQuiz()))
            {
                continue;
            }
            else
            {
                ls.Add(quizzes[i].GetQuiz());
                i++;
            }
        }
    }

    public Quiz GetQuizzes(int num)
    {
        return quizzes[num];
    }

    public bool CheckAnswer(int now_num, string a)
    {
        if (quizzes[now_num].CheckAnswer(a))
        {
            result++;
            return true;
        }

        GameObject t = Instantiate(word);
        t.transform.SetParent(Manager.instance.transform);
        WrongWord w = t.GetComponent<WrongWord>();
        w.SetWord(quizzes[now_num].GetQuiz());
        w.SetMean(quizzes[now_num].GetAnswerStr());
        w.SetWrongCount(0);
        t.SetActive(false);
        if(!Manager.instance.r.AddWrong(w))
        {
            Destroy(t);
        }
        return false;
        
    }

    public int GetResult()
    {
        return result;
    }
}
