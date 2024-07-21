
using UnityEngine;

public class Firing : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000000f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 400000 * Time.deltaTime);
            
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -250000 * Time.deltaTime);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-200000 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(200000 * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, -200000 * Time.deltaTime, 0);

        }
        if (Input.GetKey("r"))
        {
            rb.AddForce(0, 0, 1000000 * Time.deltaTime);
          
        }
        
        

    }

}
