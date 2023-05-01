using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float xRange = 8.0f;
    private float horizontalInput;
    public float jumpForce = 10.0f;
    public float gravityModifier = 1.50f;
    private Vector3 gravityMod = (new Vector3(0, -9.8f, 0));

    private Rigidbody playerRB;

    private bool isOnGround = true;


    // Start is called before the first frame update

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity = gravityMod;
    }

    // Update is called once per frame

    void Update()
    {

        MovePlayer();
        JumpPlayer();
        ConstrainPlayerPosition();
                
    }
    
    // player's movement

    void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }

    // player jump

    void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

        }
    }

    // range area

    void ConstrainPlayerPosition()
    {


        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }


}
