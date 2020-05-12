﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkholeMovement : MonoBehaviour
{
    public float speed = 0.5f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if ((transform.position.x < -658))
        {
            transform.position = new Vector3(-658, transform.position.y, transform.position.z);
        }
        if ((transform.position.x > 68))
        {
            transform.position = new Vector3(68, transform.position.y, transform.position.z);
        }
        if ((transform.position.z < -551))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -551);
        }
        if ((transform.position.z > 32))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 32);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}