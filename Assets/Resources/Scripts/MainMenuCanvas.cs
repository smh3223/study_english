using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCanvas : MonoBehaviour
{

    public enum Content{Studying, Quiz, Review};
    
    void Start()
    {
        Manager.instance.sd.MainBgm();
    }
    
    public void GoingBtn(int num)
    {
        Content c = (Content)num;
        SceneManager.LoadScene(c.ToString() + "Scene");
    }


}
