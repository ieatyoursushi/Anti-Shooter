using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonChanger : MonoBehaviour {
    public GameObject Pause_Button;
    public GameObject TwoTimes;
    public GameObject FourTimes;
    public GameObject Paused_Text;
    public GameObject Player;
    public Material skinn1;
    public Material skinn2;
    public Material skinn3;
    public Material skinn4;
    public Material skinn5;
    public Material skinn6;
    public Material skinn7;
    public Material skinn8;

    // Use this for initialization
    void Start () {
        GameObject.Find("Pause_Button");
        GameObject.Find("TwoTimes");
        GameObject.Find("FourTimes");
        GameObject.Find("Paused_Text");
        GameObject.Find("Player");
        
	}
    //Button toggle function
	public void ColorChanger()
    {
        if (Time.timeScale == 0)
        {
            Pause_Button.GetComponent<Image>().color = Color.green;

        }
        if (Time.timeScale == 1)
        {
            Pause_Button.GetComponent<Image>().color = Color.white;
        }
    }
    public void ColorChanger2()
    {
        if (Time.timeScale == 2)
        {
            TwoTimes.GetComponent<Image>().color = Color.green;
        }
        if (Time.timeScale == 1)
        {
            TwoTimes.GetComponent<Image>().color = Color.white;
        }
    }
    public void ColorChanger3()
    {
        if (Time.timeScale == 4)
        {
            FourTimes.GetComponent<Image>().color = Color.green;
        }
        if (Time.timeScale == 1)
        {
            FourTimes.GetComponent<Image>().color = Color.white;
        }
    }

    // ball skins
    public void skinOne()
    {
        Player.GetComponent<Renderer>().material = skinn1;
    }
    public void skin2()
    {
        Player.GetComponent<Renderer>().material = skinn2;
    }
    public void skin3()
    {
        Player.GetComponent<Renderer>().material = skinn3;
    }
    public void skin4()
    {
        Player.GetComponent<Renderer>().material = skinn4;
    }
    public void skin5()
    {
        Player.GetComponent<Renderer>().material = skinn5;
    }
    public void skin6()
    {
        Player.GetComponent<Renderer>().material = skinn6;
    }
    public void skin7()
    {
        Player.GetComponent<Renderer>().material = skinn7;
    }
    public void skin8()
    {
        Player.GetComponent<Renderer>().material = skinn8;
    }
}
