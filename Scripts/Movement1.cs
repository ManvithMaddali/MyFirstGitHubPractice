using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public float speed;
    private void Update()
    {
        cube1.GetComponent<Rigidbody>().AddForce(Vector3.right * speed * Time.deltaTime);
        cube2.GetComponent<Rigidbody>().AddForce(Vector3.left*speed*Time.deltaTime);
        Debug.Log(Vector3.Dot(cube1.transform.position, cube2.transform.position));
    }
    private void OnCollisionEnter(Collision collision)
    {
        cube1.transform.position=Vector3.Reflect(transform.position, Vector3.left);
        cube2.transform.position = Vector3.Reflect(transform.position, Vector3.right);
    }
}
