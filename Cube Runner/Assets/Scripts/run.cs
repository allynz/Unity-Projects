using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float movementForce = 500f;
    public float torque = 10f;

    System.Random rnd = new System.Random();
    int v1, v2, v3;

    private void Start()
    {
        v1 = rnd.Next(100);
        v2 = rnd.Next(100);
        v3 = rnd.Next(100);
        rb.AddTorque(v1, v2, v3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //int val = rnd.Next(100);
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //rb.AddTorque(v1, v2, v3);

        if (Input.GetKey("d"))
        {
            rb.AddForce(movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddTorque(0, -torque * Time.deltaTime, -torque * Time.deltaTime, ForceMode.VelocityChange);
        } else if (Input.GetKey("a"))
        {
            rb.AddForce(-movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddTorque(0, torque * Time.deltaTime, torque * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<gamemanger>().endGame();
        }

    }

}
