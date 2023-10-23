using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    AudioSource audiosrc;

    public AudioClip[] clips = new AudioClip[4];


    // Start is called before the first frame update
    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
    }

    
    public void MainBgm()
    {
        audiosrc.clip = clips[0];
        audiosrc.Play();
    }

    public void StudyBgm()
    {

        audiosrc.clip = clips[1];
        audiosrc.Play();
        
    }
    public void QuizBgm()
    {
        audiosrc.clip = clips[2];
        audiosrc.Play();
    }

    public void ReviewBgm()
    {
        audiosrc.clip = clips[3];
        audiosrc.Play();
    }

}
