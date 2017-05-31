using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameBoard : MonoBehaviour {

	//Actions will run any Method stored inside of it when activated
	
	//Stores the methods for starting a new turn
	public static Action TurnStart;

	//Stores the methods for starting a new turn
	public static Action TurnEnd;

	//Stores the different player turn as states; One for each player piece
	public enum GameState{Blue,Red,Green,Yellow,Break,XWin,OWin};

	public enum PieceType{X,O,Empty};
	
	//Stores the current active state
	public static GameState CurrentState;

	//Sets the CurrentState to Player Piece One
	void Start(){
		CurrentState = GameState.Blue;
	}
	public static void XWin(){
		CurrentState = GameState.XWin;
		GameBoard.TurnEnd();
		Debug.Log("X Won");
		SceneManager.LoadScene("XWins");
	}
	public static void OWin(){
		CurrentState = GameState.OWin;
		GameBoard.TurnEnd();
		Debug.Log("O Won");
		SceneManager.LoadScene("OWins");
	}
}