using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
     private Transform playerTransform;     
     private float yOffset = 2.0f;
     private float zOffset = -7.0f;

    private Vector3 offset;
   
    public float turnspeed = 5.0f;

    void Start()
    {
        playerTransform = player.transform;
        offset = new Vector3(playerTransform.position.x, playerTransform.position.y + yOffset, playerTransform.position.z + zOffset);
    }

    void Update()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*turnspeed, Vector3.up)*offset;
        transform.position = playerTransform.position + offset;
        transform.LookAt(playerTransform.position);
    }
}
