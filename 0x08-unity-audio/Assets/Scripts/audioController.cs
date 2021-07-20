using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public GameObject menuSfx;
    private AudioSource menuAudio;
    void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }

    public void hoverbutton(){
        menuAudio.Play();
    }
}
