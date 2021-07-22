using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public GameObject soundVFX;

    private AudioSource sceneAudioSource;
    public AudioClip [] sceneClips;
    // Start is called before the first frame update
    void Start()
    {
        sceneAudioSource = soundVFX.GetComponent<AudioSource>();


    }

   

   
    // Update is called once per frame
    void Update()
    {
      
        if(transform.position.y <= -15){
            transform.position = new Vector3(-1,20,-2);
             sceneAudioSource.clip = sceneClips[1];
             sceneAudioSource.Play();
             Debug.Log("IsFalling");
            //animator.SetBool("RunningToFalling", true);
            //animator.SetBool("JumpToFalling", true);
        }
    }

    
}
