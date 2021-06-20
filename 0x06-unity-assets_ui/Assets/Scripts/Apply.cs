using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apply : MonoBehaviour
{

    public GameObject InvertToogle;
    public Toggle Toogle;
    // Start is called before the first frame update
    public bool  isInverted;

    void Start()
    {
       Toogle =  InvertToogle.GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Toogle){
             isInverted = true;
            
        }else {
            isInverted = false;
        }
        

    }
}
