using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    float start;
    float current;
    float max = 5f;
    bool isend;
    public RectTransform bar;


    public void StartTimer()
    {
        start = Time.time;
        current = 0;
        isend = false;
    }

    public bool Check()
    {
        if (isend)
            return true;

        current = Time.time - start;
        if(current < max)
        {
            bar.sizeDelta = new Vector2(1200f - 240f * current, 100f);
            return true;
        }
        return false;
    }

    public void StopTimer()
    {
        isend = true;
    }
    
}
