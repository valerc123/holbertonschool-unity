using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class bgSound : MonoBehaviour
{
    public float backgroundSound;
    private float bgdb;
    public AudioMixer mixerbg;
     public float SFXSound;
    private float SFXdb;
    public AudioMixer SFXmixer;

    void Start()
    {
        
    }
    void Update()
    {
        backgroundSound = PlayerPrefs.GetFloat("backgroundSound");
        bgdb = 20.0f * Mathf.Log10(backgroundSound);
        mixerbg.SetFloat("bgsoundmixer", bgdb);
        PlayerPrefs.SetFloat("bgsoundvolum", backgroundSound);

        SFXSound = PlayerPrefs.GetFloat("SFXsound");
        SFXdb = 20.0f * Mathf.Log10(SFXSound);
        SFXmixer.SetFloat("SFXsoundMixer", SFXdb);
        PlayerPrefs.SetFloat("SFXsoundVolum", SFXSound);
    }
}
