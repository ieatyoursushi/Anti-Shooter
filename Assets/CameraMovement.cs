
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    [SerializeField]private Transform crb;
    [SerializeField] private Rigidbody Movement;
    public float Force = 100000f;
    public float Rorce = -1000f;


    private void Update()
    {
        if (Input.GetKey("right"))
        {
            crb.Rotate(0, 100 * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))
        {
            crb.Rotate(0, -100 * Time.deltaTime, 0);
        }
        if (Input.GetKey("up"))
        {
            crb.Rotate(-100 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            crb.Rotate(100 * Time.deltaTime, 0, 0);
        }

    }
    public void CamUp()
    {
        Movement.AddForce(0, Force * Time.deltaTime, 0);
    }

    public void CamDown()
    {
        Movement.AddForce(0, Rorce * Time.deltaTime, 0);
    }

}
