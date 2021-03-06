﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour {

	private static GameHandler instance;

	private static int player1score;
	private static int player2score;
	private static int player1time = 30;
	private static int player2time = 30;

	[SerializeField] private Player1Movement player1;
	[SerializeField] private Player2Movement player2;

	private FoodLevelGrid FoodlevelGrid;

	private void Awake(){
		instance = this;
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("GameHandler.Start");

		FoodlevelGrid = new FoodLevelGrid (40, 20);

		player1.Setup (FoodlevelGrid);
		player2.Setup (FoodlevelGrid);
		FoodlevelGrid.Setup (player1);

		InvokeRepeating("decreasePlayer1Time", 1.0f, 1.0f);
		InvokeRepeating("decreasePlayer2Time", 1.0f, 1.0f);
	}

	public static int GetPlayer1Score(){
		return player1score;
	}

	public static int GetPlayer2Score(){
		return player2score;
	}

	public static int GetPlayer1Time(){
		return player1time;
	}

	public static int GetPlayer2Time(){
		return player2time;
	}

	//adds ten points when player picks up a vegetable
	public static void AddScoreWhenPlayer1PickupVegetable(){
		player1score += 10;
	}

	public static void AddScoreWhenPlayer2PickupVegetable(){
		player2score += 10;
	}

	void decreasePlayer1Time(){
		if(player1time > 0) {
			player1time -= 1;
		}
	}

	void decreasePlayer2Time(){
		if(player2time > 0) {
			player2time -= 1;
		}
	}

	// Update is called once per frame
//	void Update () {
//	}
}