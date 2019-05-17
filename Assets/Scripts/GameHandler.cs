using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("GameHandler.Start");

		GameObject Player1GameObject = new GameObject ();
		GameObject Player2GameObject = new GameObject ();

		SpriteRenderer Player1SpriteRenderer = Player1GameObject.AddComponent<SpriteRenderer> ();
		SpriteRenderer Player2SpriteRenderer = Player2GameObject.AddComponent<SpriteRenderer> ();

		Player1SpriteRenderer.sprite = GameAssets.player1instance.Player1Sprite;
		Player2SpriteRenderer.sprite = GameAssets.player2instance.Player2Sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
