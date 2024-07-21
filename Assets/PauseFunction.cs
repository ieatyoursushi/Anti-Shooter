using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseFunction : MonoBehaviour
{
    bool Paused = false;
    bool Speed = false;
    
    public void PauseGame()
    {

        if (Paused)
        {
            Time.timeScale = 1;
            Paused = false;
            Debug.Log("Pause");
        } else{
            Time.timeScale = 0;
            Paused = true;
            Debug.Log("Resume");
        }

    }

    public void Speedgame()
    {
        if (Speed)
        {
            Time.timeScale = 1;
            Speed = false;
            Debug.Log("Times1");
        } else {
            Time.timeScale = 2;
            Speed = true;
            Debug.Log("Times2");
        }


    }
    public void Speedgame2()
    {
        if (Speed)
        {
            Time.timeScale = 1;
            Speed = false;
            Debug.Log("Times1");
        }
        else
        {
            Time.timeScale = 4;
            Speed = true;
            Debug.Log("Times4");
        }


    }

}
