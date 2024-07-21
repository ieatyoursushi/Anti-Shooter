using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    public ScoreKeeper score;

    public void OnCollisionEnter(Collision other)
    {
        score.AddPoint();
    }
}
