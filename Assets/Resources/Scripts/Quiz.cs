using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz
{
    string quiz;
    string answerStr;
    string[] wrongStr = new string[3];

    public void CreateQuiz()
    {
        int min = (Manager.instance.user.GetLevel()-1)*20;
        int max = (Manager.instance.user.GetLevel() * 20);
        int range = Random.Range(min, max);

        answerStr = Manager.instance.data[range]["word"];
        quiz = Manager.instance.data[range]["mean"];

        List<int> ls = new List<int>();
        ls.Add(range);

        for(int i =0; i<3;)
        {
            int r = Random.Range(min, max);
            if (ls.Contains(r))
            {
                continue;
            }
            else
            {
                wrongStr[i] = Manager.instance.data[r]["word"];
                ls.Add(r);
                i++;
            }
        }
        
    }

    public bool CheckAnswer(string a)
    {
        if (answerStr == a)
            return true;
        else
            return false;
    }

    public string GetQuiz()
    {
        return quiz;
    }

    public string GetAnswerStr()
    {
        return answerStr;
    }

    public string GetWrongStr(int num)
    {
        return wrongStr[num];
    }
}
