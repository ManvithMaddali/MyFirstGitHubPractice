using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manvith;

public class Movement : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        RayCast ray = new RayCast();
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(-1,0,0) *speed* Time.deltaTime);
            transform.Rotate(new Vector3(15, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            transform.Rotate(new Vector3(-15, 0, 0) * Time.deltaTime);
        }
    }

}
