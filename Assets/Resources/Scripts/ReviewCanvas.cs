using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReviewCanvas : StudyingCanvas
{
    ReviewController r;

    public Text lvtext;

    void Start()
    {
        r = GetComponent<ReviewController>();

        r.SetWrongList(Manager.instance.r.GetWrongList());
        r.MakeWrongList();

        lvtext.text = "LV. " + Manager.instance.user.GetLevel();

        Manager.instance.sd.ReviewBgm();  
    }
}
