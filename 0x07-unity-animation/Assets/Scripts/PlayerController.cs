using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
  // Start is called before the first frame update\
   [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float gravity = 40f;
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    private Vector3 movePlayer;
    private Vector3 playerInput;
   
    private float movementSpeed = 7f;
    private Vector3 move;
   
    public float fallVelocity;
    public float jumpForce;
    //public bool isGrounded = false;

    public CharacterController player;

    void Start()
    {
       player = GetComponent<CharacterController>();    
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        playerInput = new Vector3( horizontalInput, 0, verticalInput);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;

        movePlayer = movePlayer * movementSpeed ;

        setGravity ();
        PlayerJump();
        
        player.Move(movePlayer * Time.deltaTime);


        camDirection();
       
       if(transform.position.y <= -10){
            transform.position = new Vector3(0,20,0);
        }
    }

    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }


    void PlayerJump()
    {
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallVelocity = jumpForce;
            movePlayer.y = fallVelocity;
        }
    }
     void setGravity()
    {      
        if (player.isGrounded)
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
    }

  /*  public void OnCollisionEnter(Collision hit){
        if (hit.gameObject.CompareTag("ground")){
            isGrounded = true;
        }
        else {
           isGrounded = false;
        }
    }*/
 }
