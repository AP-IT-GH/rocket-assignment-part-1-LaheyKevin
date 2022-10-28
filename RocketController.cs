using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody my_rigidbody;
    private bool fly;
    private int rotate = 0;
    // Start is called before the first frame update
    void Start()
    {
        my_rigidbody = GetComponent<Rigidbody>();
        my_rigidbody.maxAngularVelocity = 10;
    }

    // Update is called once per frame
    void Update()
    {
        fly = Input.GetKey(KeyCode.Space);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotate = 1;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rotate = -1;
        }
        else
        {
            rotate = 0;
        }
    }
    void FixedUpdate()
    {
        if (fly) 
        {
            my_rigidbody.AddRelativeForce(new Vector3(0, 10, 0), ForceMode.Force);
        }
        
        transform.Rotate(0, 0, rotate);
    }
}
