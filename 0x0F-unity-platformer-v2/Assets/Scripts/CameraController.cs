using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float verticalRotationMax = 45f;
    private float verticalRotationMin = 0f;
    private Quaternion rotation;
    private float horizontalRotation;
    private float verticalRotation;
    private float vRotationModifier;
    public GameObject player;
    private Transform playerTransform;     
    private float yOffset = 3.0f;
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
    }
    void Update()
    {
        vRotationModifier = isInverted ? -1 : 1;
        if (Input.GetMouseButtonDown(1))
            mouseDown = true;
        if (Input.GetMouseButtonUp(1))
            mouseDown = false;
        
        if(mouseDown){
            verticalRotation += Input.GetAxis("Mouse Y") * vRotationModifier; 
            horizontalRotation += Input.GetAxis("Mouse X"); 
            verticalRotation = Mathf.Clamp(verticalRotation, verticalRotationMin, verticalRotationMax);
            rotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0f);     
            transform.position = playerTransform.position + rotation * offset;
            Debug.Log(isInverted );
        }else{
           // offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*turnspeed, Vector3.up)*offset;
            transform.position = playerTransform.position + offset;
        }
        transform.LookAt(playerTransform.position);
    } 
}
