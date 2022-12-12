using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoviment : MonoBehaviour
{
    public float speed = 1f;
    public float speedBoost = 2f;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        // player moviment
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, speedBoost * Time.deltaTime * horizontalInput);
        //transform.Translate(Vector3.right * speed * Time.deltaTime * verticalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        // player rotation
       
    }

}
