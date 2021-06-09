using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject timer;
    public Timer script;
    void Start()
    {
        timer = GameObject.Find("Player");
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            script = timer.GetComponent<Timer>();
            script.enabled = true;
        }
    }
}
