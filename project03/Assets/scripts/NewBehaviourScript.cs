﻿using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float speed;

	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
	    rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
                
    }
}
