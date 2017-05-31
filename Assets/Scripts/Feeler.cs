using System.Collections;
using UnityEngine;

public class Feeler : MonoBehaviour {

	//Stores the state that this object is active on
	public GameBoard.GameState CurrentTurn;

	//Used to set the GameState enum to the next state
	public GameBoard.GameState NextTurn;

//Adds Method NewTurn into an action and then calls it
	void Start(){
		GameBoard.TurnStart += Toggle;
		GameBoard.TurnEnd += Toggle;
		Toggle();
	}

	void OnTriggerEnter(Collider c){
			Disable();
	}
//If the currect turn is this player turn then move the player piece and set to next turn
	void OnMouseDown(){
		if(CurrentTurn == GameBoard.CurrentState){
			//Access the component GamePiece on the parent, pass the transform of this object and run the MovePiece Method.
			GetComponentInParent<GamePiece>().MovePiece(transform);
			
			GameBoard.CurrentState = GameBoard.GameState.Break;
			GameBoard.TurnEnd();
			
			StartCoroutine("SetToNextTurn");
		}
	}

	IEnumerator SetToNextTurn(){
		yield return new WaitForSeconds(0.5f);
		//Set the GameState to the next state
		GameBoard.CurrentState = NextTurn;
		
		//Activate the NewTurn Action on the GameBoard Script
		GameBoard.TurnStart();
	}

//Turn the collider component on or off depending on the active players turn
	void Toggle(){
		if(CurrentTurn == GameBoard.CurrentState){
			Enable();
		}else{
			Disable();
		}
	}
	void Enable(){
		if(transform.position.x > -8.51 && transform.position.x < 9.51 && transform.position.y < 10.01 && transform.position.y > -8.01){
			GetComponent<Collider>().enabled = true;
			GetComponent<MeshRenderer>().enabled = true;
		}//else{
		//	Disable();
		//}
	}
	void Disable(){
		GetComponent<Collider>().enabled = false;
		GetComponent<MeshRenderer>().enabled = false;
	}
}