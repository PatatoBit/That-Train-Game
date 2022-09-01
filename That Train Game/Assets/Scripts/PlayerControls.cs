using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    float controlSpeed = 0.25f;
    float maxSpeed = 200;
    float minSpeed = -50f;

    Follower follower;
    Rigidbody rb;

    void Start()
    {
        follower = GetComponent<Follower>();
        rb = GetComponent<Rigidbody>();

        Debug.Log(follower.speed);
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        Debug.Log(follower.speed);
        if (Input.GetKey(KeyCode.W) && follower.speed < maxSpeed)
        {
			follower.speed += controlSpeed;
        }
        if (Input.GetKey(KeyCode.S) && follower.speed > minSpeed)
        {
            follower.speed -= controlSpeed;
        }

        if (Input.GetKey(KeyCode.Backspace))
        {
            follower.speed = 0f;
        }
        if (Input.GetKey(KeyCode.X))
        {
            rb.useGravity = true;
            follower.enabled = false;
        }

	}
}
