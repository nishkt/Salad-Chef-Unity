using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour {
	private Text Player1Score;
	private Text Player2Score;
	private Text Player1Time;
	private Text Player2Time;

	private void Awake(){
		Player1Score = transform.Find ("Player1Score").GetComponent<Text> ();//grab score from UI
		Player2Score = transform.Find ("Player2Score").GetComponent<Text> ();
		Player1Time = transform.Find ("Player1Time").GetComponent<Text> ();//grab time from UI
		Player2Time = transform.Find ("Player2Time").GetComponent<Text> ();
	}

	private void Update(){
		Player1Score.text = GameHandler.GetPlayer1Score().ToString();
		Player2Score.text = GameHandler.GetPlayer2Score().ToString();
		Player1Time.text = GameHandler.GetPlayer1Time ().ToString ();
		Player2Time.text = GameHandler.GetPlayer2Time ().ToString ();
	}
}
