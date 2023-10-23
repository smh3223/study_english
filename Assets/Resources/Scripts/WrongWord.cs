using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongWord : Word
{
    int wrong_count;

    public WrongWord(string w, string m, int c)
    {
        word = w;
        mean = m;
        wrong_count = c;
    }

    public void SetWrongCount(int c)
    {
        wrong_count = c;
    }

    public int GetWrongCount()
    {
        return wrong_count;
    }
}
