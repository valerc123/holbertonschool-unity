using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerText.text = Time.time.ToString();
    }
}
