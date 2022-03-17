using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class bgSound : MonoBehaviour
{
    public float backgroundSound;
     public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;
    private float bgdb;
    public AudioMixer mixerbg;
     public float SFXSound;
    private float SFXdb;
    public AudioMixer SFXmixer;
    public GameObject canvas;
    private bool canvasActive;
    

    void Start()
    {
        
    }
    void Update()
    {
        if (!canvas.activeSelf){
            // commet to escape
           audioController();
        }else{
            Lowpass();
        }
        
    }
    void audioController(){
        backgroundSound = PlayerPrefs.GetFloat("backgroundSound");
        bgdb = 20.0f * Mathf.Log10(backgroundSound);
        mixerbg.SetFloat("bgsoundmixer", bgdb);
        PlayerPrefs.SetFloat("bgsoundvolum", backgroundSound);

        SFXSound = PlayerPrefs.GetFloat("SFXsound");
        SFXdb = 20.0f * Mathf.Log10(SFXSound);
        SFXmixer.SetFloat("SFXsoundMixer", SFXdb);
        PlayerPrefs.SetFloat("SFXsoundVolum", SFXSound);
    }
    void Lowpass(){
        if (Time.timeScale == 0){
            paused.TransitionTo(.01f);
            Debug.Log("pause");
        }else{
            Debug.Log("unpause");
            unpaused.TransitionTo(.01f);
        }
    } 
}
