using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;
    public Timer script;
    public Text text;
     public Text finalTimerText;
     public GameObject finalTime;
    void Start()
    {
        player = GameObject.Find("Player");
        canvas = GameObject.Find("WinCanvas");
        finalTime = GameObject.Find("FinalTime");
        finalTimerText = finalTime.GetComponent<Text>();
        canvas.SetActive(false);
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            script = player.GetComponent<Timer>();
            script.enabled = false;

            canvas.SetActive(true);
            finalTimerText.text = PlayerPrefs.GetString("timerFormat");;
            text.fontSize = 60;
            text.color = Color.green;
        }
    }
}
