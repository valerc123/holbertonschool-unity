using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    public GameObject InvertToogle;
     private Transform playerTransform;     
     private float yOffset = 1.0f;
     private float zOffset = -5.0f;

    private Vector3 offset;
    private Vector3 offsety;
   
    public float turnspeed = 5.0f;

    public bool  isInverted;

    void Start()
    {
        playerTransform = player.transform;
        offset = new Vector3(playerTransform.position.x , playerTransform.position.y + yOffset, playerTransform.position.z + zOffset);
        offsety = new Vector3(playerTransform.position.x , playerTransform.position.y +yOffset, playerTransform.position.z + zOffset );
        
    }

    void Update()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*turnspeed, Vector3.up)*offset;
        offsety = Quaternion.AngleAxis(Input.GetAxis("Mouse Y")*turnspeed, Vector3.left)*offsety;
        if(isInverted){
            transform.position = playerTransform.position + offset+(offsety*-1);
        }else {
            transform.position = playerTransform.position + offset+offsety;
        }

        transform.LookAt(playerTransform.position);
    }



}
