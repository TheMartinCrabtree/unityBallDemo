using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void FixedUpdate()
    {
        // get keyboard inputs
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement);
    }
}
