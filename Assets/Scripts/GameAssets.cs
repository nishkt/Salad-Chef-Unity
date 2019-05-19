using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour {

	public static GameAssets gameInstance;
//	public static GameAssets player2instance;

	private void Awake(){
		gameInstance = this;
//		player2instance = this;
	}

	public Sprite Player1Sprite;
	public Sprite Player2Sprite;
	public Sprite CucumberSprite;
	public Sprite TomatoSprite;
	public Sprite AvocadoSprite;
	public Sprite CarrotSprite;
	public Sprite LettuceSprite;
	public Sprite OnionSprite;
}
