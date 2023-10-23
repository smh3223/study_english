using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance = null;
    public User user;
    public List<Dictionary<string, string>> data;
    public ReviewController r;
    public SoundManager sd;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        ReadData();
    }
    private void ReadData() // 영단어 읽어오는 부분
    {
        data = CSVReader.Read("data/BIGVOCA_LIST");
    }
    
}
