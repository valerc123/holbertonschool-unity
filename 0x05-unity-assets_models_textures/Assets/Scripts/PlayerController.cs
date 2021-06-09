using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update\
    public Rigidbody rb;
    private float movementSpeed = 5f;
    private Vector3 move;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0,  verticalInput * movementSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.Space)) {
           // move = new Vector3()
           rb.AddForce(Vector3.up * movementSpeed);

        } 
    }
}
