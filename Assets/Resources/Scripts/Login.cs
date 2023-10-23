using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int lv = PlayerPrefs.GetInt("level", 1);
        int exp = PlayerPrefs.GetInt("exp", 0);
        Enter_data("abc", lv, exp); // 로그인 데이터베이스에서 읽어온 뒤 입력, 지금은 임시
    }

    void Enter_data(string name, int level, int exp)
    {
        Manager.instance.user.SetNickname(name);
        Manager.instance.user.SetLevel(level);
        Manager.instance.user.SetExp(exp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
