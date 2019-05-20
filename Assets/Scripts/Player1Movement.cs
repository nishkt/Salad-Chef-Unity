using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Movement : MonoBehaviour {

	private enum State
	{
		Alive,
		Dead
	}


	private State state;
	private Vector2Int gridPosition;
	private FoodLevelGrid FoodlevelGrid;

	//used to reference in GameHandler.cs
	public void Setup(FoodLevelGrid FoodlevelGrid) {
		this.FoodlevelGrid = FoodlevelGrid; 
	}
	 
	private void Awake(){
		gridPosition = new Vector2Int (-4, -8);

		state = State.Alive;
	}

	private void Update(){
		switch (state) {
		case State.Alive:	
			HandleInput ();
			HandleGridMovement ();
			break;
		case State.Dead:
			break;

		}

	}

	private void HandleInput(){
		if (Input.GetKeyDown (KeyCode.W)) {
			gridPosition.y += 1;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			gridPosition.x -= 1;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			gridPosition.y -= 1;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			gridPosition.x += 1;
		}

		gridPosition = FoodlevelGrid.validateGridPosition (gridPosition);
	}

	private void HandleGridMovement(){
		transform.position = new Vector3 (gridPosition.x, gridPosition.y);

		FoodlevelGrid.Player1Moved(gridPosition);
	}
}
