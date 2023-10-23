using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizCanvas : MonoBehaviour
{
    QuizController c;
    public Text quiz_text;
    public Text[] btn_text = new Text[5];
    public GameObject Result_obj;
    public Text res_text;
    public Text exp_text;
    public GameObject LvUP_text;
    int now_num;
    Timer timer;

    void Start()
    {
        now_num = 0;
        c = GetComponent<QuizController>();
        timer = GetComponent<Timer>();

        timer.StartTimer();
        c.MakeQuiz();
        PrintQuiz();

        Manager.instance.sd.QuizBgm();

    }

    private void Update()
    {
        if(!timer.Check())
        {
            AnswerBtn(4);
        }
    }

    void PrintQuiz()
    {
        quiz_text.text = c.GetQuizzes(now_num).GetQuiz();

        int r = Random.Range(0, 4);
        List<int> ls = new List<int>(); 
        btn_text[r].text = c.GetQuizzes(now_num).GetAnswerStr();

        ls.Add(r);
        for (int i = 0; i < 3;)
        {
            r = Random.Range(0, 4);
            if (ls.Contains(r))
                continue;
            else
            {
                btn_text[r].text = c.GetQuizzes(now_num).GetWrongStr(i);
                ls.Add(r);
                i++;
            }
        }
    }
    
    public void AnswerBtn(int num)
    {
        if(c.CheckAnswer(now_num, btn_text[num].text))
        {
            //정답 이펙트
        }
        else
        {
            //오답 이펙트
        }
        if (now_num < 9)
        {
            now_num++;
            PrintQuiz();
            timer.StartTimer();
        }       
        else
        {
            printResult();
            timer.StopTimer();
        }
            
    }

    void printResult()
    {
        if(Manager.instance.user.AddExp(c.GetResult()))
        {
            LvUP_text.SetActive(true);
        }
        
        res_text.text = "정답: " + c.GetResult();
        exp_text.text = "현재 경험치: " + Manager.instance.user.GetExp();

        Result_obj.SetActive(true);
    }

    public void GoingBtn(int num)
    {
        if (num == 0)
        {
            SceneManager.LoadScene("MainMenuScene");
        }
        else
        {
            SceneManager.LoadScene("QuizScene");
        }
    }
}
