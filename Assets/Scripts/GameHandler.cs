using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour {
	
	[SerializeField] private Player1Movement player1;
	[SerializeField] private Player2Movement player2;

	private FoodLevelGrid FoodlevelGrid;

	// Use this for initialization
	void Start () {
		Debug.Log ("GameHandler.Start");

		FoodlevelGrid = new FoodLevelGrid (40, 20);

		player1.Setup (FoodlevelGrid);
		player2.Setup (FoodlevelGrid);
		FoodlevelGrid.Setup (player1);
		//FoodlevelGrid.Setup (player2);
	}
	
	// Update is called once per frame
	void Update () {
	}
}