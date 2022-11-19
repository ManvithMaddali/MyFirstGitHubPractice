using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Vector3 forceAmount;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0,0,-1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,1*8,1*4),ForceMode.Acceleration);
        }
    }
}
