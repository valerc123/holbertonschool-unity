using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    private AudioSource menuAudio;
    public AudioClip [] menuClips;
    void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }

    public void hoverbutton(){
        menuAudio.clip = menuClips[0];
        menuAudio.Play();
    }
    public void onClickButton(){
        menuAudio.clip = menuClips[1];
        menuAudio.Play();
    }
}
