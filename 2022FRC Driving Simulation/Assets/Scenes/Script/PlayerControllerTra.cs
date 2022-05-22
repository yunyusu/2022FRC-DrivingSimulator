using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTra : MonoBehaviour
{
    public float speed = 40.0f;
    public float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves the vehicle forward based on vertical input
        transform.Translate(Vector3.right * Time.deltaTime * speed * forwardInput * -1);
        //Moves the vehicle forward based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
