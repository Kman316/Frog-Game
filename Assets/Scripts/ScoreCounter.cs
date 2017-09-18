using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour {

    public static int score;
    private Text scoreCounterText;


	// Use this for initialization
	void Start () {
        score = 0;
        scoreCounterText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreCounterText.text = score + " Flies";
	}
}
