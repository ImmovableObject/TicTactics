using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour {

	//public GameObject Board;

	// Use this for initialization
	public void ResetGame () {
		GameBoard.TurnStart = null;
		GameBoard.TurnEnd = null;
		//GameBoard.CurrentState = GameBoard.GameState.Blue;
		//GameBoard.TurnStart();
		SceneManager.LoadScene("TestLevel");
	}

	public void QuitGame () {
		Application.Quit();
	}
}
