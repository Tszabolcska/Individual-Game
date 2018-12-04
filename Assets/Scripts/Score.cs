using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public GameObject enemy;
    public Text scoreText;
    public static int score;
	// Use this for initialization
	void Start () {
        score = 0;   
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score.ToString();
    }

    //public void addScore(int newScore)
    //{
    //    score += newScore;
    //}

}
