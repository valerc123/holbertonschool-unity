using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public  float timer;
    public GameObject finalTime;
    public GameObject timerCanvas;
    public Text TimerText;
    public Text finalTimerText;
    public string timerFormatted;
    public string timerFormat;

    public bool col;
    void Start()
    {
        timerCanvas = GameObject.Find("TimerCanvas");
        //finalTimerText = finalTime.GetComponent<Text>();
        col = true;
    }
    void Update()
    {
        timerFormat = timerFormatted;
        //Debug.Log(timerFormat + "timer format");
       // TimerText.text = timerFormat;
        if(col){
            clock();
        }else{
            TimerText.text = timerFormat;
        }
    }
    string clock (){
        TimeSpan t =  TimeSpan.FromSeconds(timer);
        timerFormatted = string.Format("{0:D2}:{1:D2}:{2:D2}",t.Minutes, t.Seconds, t.Milliseconds);
        timer += Time.deltaTime;
        TimerText.text = timerFormat;
        return timerFormatted;
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "winflag"){
            Win();
            col = true;
            Debug.Log("winflag");
          //  TimerText.text = timerFormatted;
        }
    }
    public void Win(){
        timerCanvas.SetActive(false);
        PlayerPrefs.SetString("timerFormat",timerFormat);
        //finalTimerText.text = timerFormat;
    }
}
