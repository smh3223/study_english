using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StudyingCanvas : MonoBehaviour
{
    StudyingController c;

    public Toggle tgl_mean;
    public Toggle tgl_word;
    public Text text_lv;
    protected GameObject[] mean_list;
    protected GameObject[] word_list;

    void Start()
    {
        c = GetComponent<StudyingController>();
        c.MakeWordList();
        printWord();

        text_lv.text = "LV. " + Manager.instance.user.GetLevel().ToString();
        Manager.instance.sd.StudyBgm();
    }

    void printWord()
    {
        mean_list = new GameObject[20];
        word_list = new GameObject[20];
        Word[] li = c.GetWordList();
        for (int i = 0; i < 20; i++)
        {
            word_list[i] = li[i].transform.GetChild(0).gameObject;
            mean_list[i] = li[i].transform.GetChild(1).gameObject;
        }
    }

    public void wordToggleChanged()
    {
        for(int i=0; i<20; i++)
        {
            word_list[i].SetActive(tgl_word.isOn);
        }
    }
    
    public void meanToggleChanged()
    {
        for (int i = 0; i < 20; i++)
        {
            mean_list[i].SetActive(tgl_mean.isOn);
        }
    }

    public void ReturnBtn()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    
}
