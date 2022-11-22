using UnityEngine;
using System.Collections;

public class AddTorqueExample : MonoBehaviour
{
    public float amount = 50f;


    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

        GetComponent<Rigidbody>().AddTorque(new Vector3(0,0,10) * h);
        GetComponent<Rigidbody>().AddTorque(new Vector3(0,10,0) * v);
    }
}
