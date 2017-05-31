using UnityEngine;

public class GamePiece : MonoBehaviour {

	public GameBoard.GameState Turn;
	public GameBoard.PieceType Type;

	//Adds the MovePiece Method to the Movement Action
		
	//Move the player piece to the Transform that is passed to it from the feeler script
	public void MovePiece(Transform t){	
		if(GameBoard.CurrentState == Turn){
			transform.position = t.position;
		}
	}
}