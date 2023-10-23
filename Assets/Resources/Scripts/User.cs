using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    string nickname;
    int level;
    int exp;

    public string GetNickname()
    {
        return nickname;
    }

    public void SetNickname(string n)
    {
        nickname = n;
    }
    public int GetLevel()
    {
        return level;
    }

    public void SetLevel(int l)
    {
        level = l;
    }

    public void LevelUp()
    {
        level++;
        PlayerPrefs.SetInt("level", level);
    }
    public int GetExp()
    {
        return exp;
    }

    public void SetExp(int e)
    {
        exp = e;
    }

    public bool AddExp(int e)
    {
        exp += e;
        if (exp >= 20)
        {
            LevelUp();
            exp = exp - 20;
            PlayerPrefs.SetInt("exp", exp);
            return true;
        }
        else
        {
            PlayerPrefs.SetInt("exp", exp);
            return false;

        }
    }
}
