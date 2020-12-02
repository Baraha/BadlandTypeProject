using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float playerSpeed = 200f;
    public float playerGetUp = 100f;
    public Transform Camera;
    public Transform player;
    public Vector3 offset;
    public Transform HeroPosition;
    void FixedUpdate()
    {
        rb.transform.Translate(playerSpeed/10*Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0,playerGetUp*Time.deltaTime,0);
        }
        Camera.transform.position = player.transform.position + offset;
        HeroPosition.transform.position = player.transform.position;

    }
}
