using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
     private Transform playerTransform;     
     private float yOffset = 1.0f;
     private float zOffset = -5.0f;

    private Vector3 offset;
    public float turnspeed = 5.0f;
    public bool mouseDown;
    public bool  isInverted;

    void Start()
    {
        if (PlayerPrefs.HasKey("inverse")){
            isInverted = PlayerPrefs.GetInt("inverse") == 1 ? true : false;
            Debug.Log(PlayerPrefs.GetInt("inverse"));
        }else{
            isInverted = false;
        }
        playerTransform = player.transform;
        offset = new Vector3(playerTransform.position.x , playerTransform.position.y + yOffset, playerTransform.position.z + zOffset);
       // offsety = new Vector3(playerTransform.position.x , playerTransform.position.y +yOffset, playerTransform.position.z + zOffset );
     
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
            mouseDown = true;
        if (Input.GetMouseButtonUp(1))
            mouseDown = false;
        
        if(mouseDown){
            if (isInverted){
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y")*turnspeed, Vector3.left)*offset;         
                transform.position = playerTransform.position + offset;
                Debug.Log(isInverted + " invert");

            }else{
               offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y")*turnspeed, Vector3.left)*offset;         
                transform.position = playerTransform.position + offset; 
                Debug.Log(isInverted + " notinvert");
            }

        }else{
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*turnspeed, Vector3.up)*offset;
            transform.position = playerTransform.position + offset;
        }
       Debug.Log(mouseDown + " mousedown");
        
       transform.LookAt(playerTransform.position);
    } 
}
