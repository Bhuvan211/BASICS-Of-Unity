using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float jumpForce = 5f;
    //[SerializeField] private int isGrounded = 0;
    [SerializeField] private Rigidbody rb ;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        //ContinewMovement();
        MovePlayer();        
    }
    private void MovePlayer()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        transform.position += transform.forward * Time.deltaTime * speed;
        Debug.Log("Accelerate" + speed);
        //float HorizontalInput = Input.GetAxis("Horizontal");
        //float VerticalInput = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(HorizontalInput, 0f, VerticalInput) * speed * Time.deltaTime;
       // transform.Translate(movement, Space.World);
        //Debug.Log("Left");
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Jump");
        //    rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //}
    }
    public void turnLeft()
    {
        transform.Rotate(0,10f,0);
    }
    public void turnRight()
    {
        transform.Rotate(0, -10f, 0);
    }
    public void Accelerate()
    {
        speed += 1f;
        Debug.Log("Accelerate1" + speed);
    }
    public void Break()
    {
        if (speed > 1f)
        {
            speed -= 1f;
            Debug.Log("Break" + speed);
        }
        else
        {
            speed = 0f;
        }
    }

    //private void ContinewMovement()
    //{
    //    transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
    //}
}
