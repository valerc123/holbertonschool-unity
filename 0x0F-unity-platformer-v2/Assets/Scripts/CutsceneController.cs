using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;
    public GameObject timerCanvas;
    public PlayerController scriptPc;
    public CutsceneController scriptCs;

    void Start()
    {
        player = GameObject.Find("Player");
        //scriptPc = player.GetComponent<PlayerController>();
        scriptCs = gameObject.GetComponent<CutsceneController>();
    }
    public void activeComponents(){
        mainCamera.SetActive(true);
        //scriptPc.enabled = true;
        timerCanvas.SetActive(true);
        scriptCs.enabled = false;
        gameObject.SetActive(false);
    }
    void Update()
    {
        
    }
}
