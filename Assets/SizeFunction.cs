using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeFunction : MonoBehaviour {
    public Vector3 temp;


	// Update is called once per frame
	void Update () {
        temp = transform.localScale;
        if (Input.GetKey("4"))
        {
            temp.x += 1f;
            temp.y += 1f;
            temp.z += 1f;
        }
        if (Input.GetKey("3"))
        {
            temp.x -= 1f;
            temp.y -= 1f;
            temp.z -= 1f;
        }
        if(Input.GetKey("5"))
        {
            temp.x = 10f;
            temp.y = 10f;
            temp.z = 10f;
        }

        transform.localScale = temp;
    }
    public void OnclickPlus()
    {
        temp.x += 1f;
        temp.y += 1f;
        temp.z += 1f;
    }
    public void OnClickMinus()
    {
        temp.x -= 1f;
        temp.y -= 1f;
        temp.z -= 1f;
    }
}
