using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamb : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //InvokeRepeating("Jump",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
