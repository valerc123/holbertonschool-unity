using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
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
    public float rotationY;
    public GameObject ty;
    Animator animator;
     private Quaternion charRotation;

    void Start()
    {
       player = GetComponent<CharacterController>();
       animator = ty.GetComponent<Animator>();
    }
    void Update()
    {  
       
        if (  (Input.GetKey(KeyCode.W) || 
                Input.GetKey(KeyCode.A) ||
                Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.D) ) ||
                (
                    Input.GetKey(KeyCode.UpArrow) ||
                    Input.GetKey(KeyCode.LeftArrow) ||
                    Input.GetKey(KeyCode.DownArrow) ||
                    Input.GetKey(KeyCode.RightArrow) 
                )
        ) {
            animator.SetBool("IsRunning", true);              
        } else {
            animator.SetBool("IsRunning", false);         
        } 

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        playerInput = new Vector3(horizontalInput, 0, verticalInput);
        Vector3.Normalize(playerInput);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;

        movePlayer = movePlayer * movementSpeed;
        
        setGravity();
        PlayerJump();
        

        if (playerInput.magnitude != 0)
        {
           player.transform.LookAt(player.transform.position + movePlayer);
           rotationY = player.transform.eulerAngles.y;
           player.transform.rotation = Quaternion.Euler(0, rotationY, 0);
           
        }
      
        player.Move(movePlayer * Time.deltaTime);

        camDirection();
       
       if(transform.position.y <= -15){
            transform.position = new Vector3(0,30,0);
             Debug.Log("IsFalling");
            //animator.SetBool("RunningToFalling", true);
            animator.SetBool("JumpToFalling", true);
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
            animator.SetBool("IsJumping", true);
            fallVelocity = jumpForce;
            movePlayer.y = fallVelocity;
            Debug.Log(animator.GetBool("IsJumping"));
        }else {
            animator.SetBool("IsJumping", false);
            
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
 }
