using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update\
    public Rigidbody rb;
    private float movementSpeed = 5f;
    private Vector3 move;
    public int jump;
    public float jumpHeight = 6f;
    public bool isGrounded = false;

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
        transform.rotation = Quaternion.Euler(0,0,0);
        if ((Input.GetKey(KeyCode.Space)) && (isGrounded == true)) {
            gameObject.transform.Translate(0, 0.1f , 0);
          //  rb.AddForce(Vector3.up * jumpHeight);
        }

        if(transform.position.y <= -10){
            transform.position = new Vector3(0,20,0);
        }
    }
    public void OnCollisionEnter(Collision hit){
        if (hit.gameObject.CompareTag("ground")){
            isGrounded = true;
        }else{
            isGrounded = false;
        }
    }
}
