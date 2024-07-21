using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraOnClick : MonoBehaviour {
    public GameObject TheCamera;
    void Start()
    {
        GameObject.Find("TheCamera");
    }

    public void CameraUp()
    {
        TheCamera.GetComponent<CameraMovement>().CamUp();
    }
    public void CameraDown()
    {
        TheCamera.GetComponent<CameraMovement>().CamDown();
    }



}
