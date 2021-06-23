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
    void Start()
    {
        player = GameObject.Find("Player");
        canvas = GameObject.Find("WinCanvas");
        canvas.SetActive(false);

    }

    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            script = player.GetComponent<Timer>();
            script.enabled = false;

            canvas.SetActive(true);
            text.fontSize = 60;
            text.color = Color.green;

        }
    }
}
