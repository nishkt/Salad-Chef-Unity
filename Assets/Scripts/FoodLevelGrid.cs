﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

public class FoodLevelGrid {

	private Vector2Int cucumberGridPosition;
	private Vector2Int tomatoGridPosition;
	private Vector2Int lettuceGridPosition;
	private Vector2Int avocadoGridPosition;
	private Vector2Int onionGridPosition;
	private Vector2Int carrotGridPosition;
	private GameObject cucumberGameObject;
	private GameObject tomatoGameObject;
	private GameObject lettuceGameObject; 
	private GameObject avocadoGameObject;
	private GameObject onionGameObject;
	private GameObject carrotGameObject;

	private int width;
	private int height;

	private Player1Movement player1;
	private Player2Movement player2;

	public FoodLevelGrid(int width, int height){
		this.width = width;
		this.height = height;

		SpawnCucumber();
		SpawnTomato ();
		SpawnLettuce ();
		SpawnAvocado ();
		SpawnOnion ();
		SpawnCarrot ();
	}

	//calls for a reference in GameHandler.cs
	public void Setup(Player1Movement player1){
		this.player1 = player1;
	}

	//spawn methods used to show vegetables on the screen
	private void SpawnCucumber(){
		cucumberGridPosition = new Vector2Int (-18, -8);


		cucumberGameObject = new GameObject ("Cucumber", typeof(SpriteRenderer));
		cucumberGameObject.GetComponent<SpriteRenderer> ().sprite = GameAssets.gameInstance.CucumberSprite;
		cucumberGameObject.transform.position = new Vector3 (cucumberGridPosition.x, cucumberGridPosition.y);
	}

	private void SpawnTomato(){
		tomatoGridPosition = new Vector2Int (-18, -4);

		tomatoGameObject = new GameObject ("Tomato", typeof(SpriteRenderer));
		tomatoGameObject.GetComponent<SpriteRenderer> ().sprite = GameAssets.gameInstance.TomatoSprite;
		tomatoGameObject.transform.position = new Vector3 (tomatoGridPosition.x, tomatoGridPosition.y);
	}

	private void SpawnLettuce(){
		lettuceGridPosition = new Vector2Int (-18, 0);

		lettuceGameObject = new GameObject ("Lettuce", typeof(SpriteRenderer));
		lettuceGameObject.GetComponent<SpriteRenderer> ().sprite = GameAssets.gameInstance.LettuceSprite;
		lettuceGameObject.transform.position = new Vector3 (lettuceGridPosition.x, lettuceGridPosition.y);
	}

	private void SpawnAvocado(){
		avocadoGridPosition = new Vector2Int (18, -8);

		avocadoGameObject = new GameObject ("Avocado", typeof(SpriteRenderer));
		avocadoGameObject.GetComponent<SpriteRenderer> ().sprite = GameAssets.gameInstance.AvocadoSprite;
		avocadoGameObject.transform.position = new Vector3 (avocadoGridPosition.x, avocadoGridPosition.y);
	}

	private void SpawnOnion(){
		onionGridPosition = new Vector2Int (18, -4);

		onionGameObject = new GameObject ("Onion", typeof(SpriteRenderer));
		onionGameObject.GetComponent<SpriteRenderer> ().sprite = GameAssets.gameInstance.OnionSprite;
		onionGameObject.transform.position = new Vector3 (onionGridPosition.x, onionGridPosition.y);
	}

	private void SpawnCarrot(){
		carrotGridPosition = new Vector2Int (18, 0);

		carrotGameObject = new GameObject ("Carrot", typeof(SpriteRenderer));
		carrotGameObject.GetComponent<SpriteRenderer> ().sprite = GameAssets.gameInstance.CarrotSprite;
		carrotGameObject.transform.position = new Vector3 (carrotGridPosition.x, carrotGridPosition.y);
	}

	//Method to check if player1 is in the ssame position as one of the vegetables
	public void Player1Moved(Vector2Int player1GridPosition){
		if (player1GridPosition == cucumberGridPosition) {
			Object.Destroy (cucumberGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Cucumber was grabbed by player 1!");
		}
		if (player1GridPosition == tomatoGridPosition) {
			Object.Destroy (tomatoGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Tomato was grabbed by player 1!");
		}
		if (player1GridPosition == lettuceGridPosition) {
			Object.Destroy (lettuceGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Lettuce was grabbed by player 1!");
		}
		if (player1GridPosition == avocadoGridPosition) {
			Object.Destroy (avocadoGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Avocado was grabbed by player 1!");
		}
		if (player1GridPosition == onionGridPosition) {
			Object.Destroy (onionGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Onion was grabbed by player 1!");
		}
		if (player1GridPosition == onionGridPosition) {
			Object.Destroy (onionGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Onion was grabbed by player 1!");
		}
	}

	//Method to check if player1 is in the ssame position as one of the vegetables
	public void Player2Moved(Vector2Int player2GridPosition){
		if (player2GridPosition == cucumberGridPosition) {
			Object.Destroy (cucumberGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Cucumber was grabbed by player 2!");
		}
		if (player2GridPosition == tomatoGridPosition) {
			Object.Destroy (tomatoGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Tomato was grabbed by player 2!");
		}
		if (player2GridPosition == lettuceGridPosition) {
			Object.Destroy (lettuceGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Lettuce was grabbed by player 2!");
		}
		if (player2GridPosition == avocadoGridPosition) {
			Object.Destroy (avocadoGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Avocado was grabbed by player 2!");
		}
		if (player2GridPosition == onionGridPosition) {
			Object.Destroy (onionGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Onion was grabbed by player 2!");
		}
		if (player2GridPosition == onionGridPosition) {
			Object.Destroy (onionGameObject);

			//SpawnCucumber();
			CMDebug.TextPopupMouse ("Onion was grabbed by player 2!");
		}
	}
}
