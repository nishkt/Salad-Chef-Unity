using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour {

	public static GameAssets player1instance;
	public static GameAssets player2instance;

	private void Awake(){
		player1instance = this;
		player2instance = this;
	}

	public Sprite Player1Sprite;
	public Sprite Player2Sprite;
}
