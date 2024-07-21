using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestart : MonoBehaviour {

	public void Resetting () {  
        //reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene ().name);

    }
}
