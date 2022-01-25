using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotation : MonoBehaviour
{
    public float HorizontalRotation;
    public float VerticalRotation;
    bool forward = false;
    public float speed = 50f;
    public float x = 1, y = 1, z = 1;

    public float rotationSpeed = 100f;


    void Update()
    {
        HorizontalRotation = Input.GetAxis("Horizontal");
        VerticalRotation = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * HorizontalRotation);
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * VerticalRotation);

        if (Input.GetKey("space"))
        {
            transform.localScale = transform.localScale + new Vector3(Time.deltaTime * x, Time.deltaTime * y, Time.deltaTime * z);
        }
        if (Input.GetKeyUp("space"))
        {
            while (transform.localScale.x > 1)
            {
                transform.localScale = transform.localScale - new Vector3(Time.deltaTime * x, Time.deltaTime * y, Time.deltaTime * z);
            }
        }
        
    }
}
