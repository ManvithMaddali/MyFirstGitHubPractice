using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Scripts : MonoBehaviour
{
    private Rigidbody rb;
    private float AmountOfForce=5f;
    //public Rigidbody trampolineRigidBody;
    private int count;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            AmountOfForce+=2*Time.deltaTime;
            rb.AddForce(new Vector3(0, 1, 1) * AmountOfForce, ForceMode.Acceleration);
            }
        Debug.Log(AmountOfForce);

    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }
}