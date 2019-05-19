using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {

	private Vector2Int gridPosition;
	private FoodLevelGrid FoodlevelGrid;

	//used to reference in GameHandler.cs
	public void Setup(FoodLevelGrid FoodlevelGrid) {
		this.FoodlevelGrid = FoodlevelGrid; 
	}
	 
	private void Awake(){
		gridPosition = new Vector2Int (-4, -8);
	}

	private void Update(){
		HandleInput ();
		HandleGridMovement ();
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
	}

	private void HandleGridMovement(){
		transform.position = new Vector3 (gridPosition.x, gridPosition.y);

		FoodlevelGrid.Player1Moved(gridPosition);
	}
}
