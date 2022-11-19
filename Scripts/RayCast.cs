using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public GameObject ground;
    public float deploymentHeight;
    public float effectiveness;
    public GameObject danceAnim;
    private bool deploy;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        danceAnim.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.up);  
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        if (!deploy)
        {
            if(Physics.Raycast(landingRay,out hit, deploymentHeight))
            {
                if (hit.collider.tag == "Ground")
                {
                    Dance();
                }
            }
        }
    }
    void Dance()
    {
        deploy = true;
        rb.drag = effectiveness;
        danceAnim.GetComponent<Animator>().enabled = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        danceAnim.GetComponent<Animator>().enabled = false;
    }
}
