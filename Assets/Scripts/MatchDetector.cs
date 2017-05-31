using UnityEngine;

public class MatchDetector : MonoBehaviour {

	public GameBoard.PieceType MatchType;

	void Start(){
		GameBoard.TurnStart += Toggle;
		GameBoard.TurnEnd += Toggle;
		Toggle();
	}

	public void Toggle(){
		if(GameBoard.CurrentState == GameBoard.GameState.Break){
			GetComponent<Collider>().enabled = true;
		}else{
			GetComponent<Collider>().enabled = false;
		}
	}

	void OnTriggerEnter(Collider c){
		MatchType = c.GetComponent<GamePiece>().Type;
	}

	public void SetToEmpty(){
		MatchType = GameBoard.PieceType.Empty;
	}
}