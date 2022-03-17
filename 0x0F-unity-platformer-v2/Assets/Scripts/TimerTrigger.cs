using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject player;
    public Timer script;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            script = player.GetComponent<Timer>();
            script.enabled = true;
            Debug.Log ("timer");
        }
    }
}
