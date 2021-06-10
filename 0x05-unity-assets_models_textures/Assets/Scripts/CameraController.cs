using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = player.transform.position + offset;
        float horizontalInput = Input.GetAxis("Mouse X");
       // transform.Rotate(0, horizontalInput, 0);
       // transform.RotateAround(player.transform.position, Vector3.up, horizontalInput);
       // transform.LookAt(player.transform.position);
    }
}
