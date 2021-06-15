using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class flagTrigger : MonoBehaviour
{
    public GameObject player;
    public Timer script;
    public Text text;
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
            script.enabled = false;

            text.fontSize = 60;
            text.color = Color.green;
        }
    }
}
