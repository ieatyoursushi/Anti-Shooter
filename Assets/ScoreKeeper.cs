using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour {
    public Text score;
    int points = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "Points: " + points.ToString();
	}

    //add points

    public void AddPoint()
    {
        points = points + 1;
    }
}
