using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -15){
            transform.position = new Vector3(-1,20,-2);
             Debug.Log("IsFalling");
            //animator.SetBool("RunningToFalling", true);
            //animator.SetBool("JumpToFalling", true);
        }
    }
}
