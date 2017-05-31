using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

	public void StartScene (string s) {
		GameBoard.TurnStart = null;
		GameBoard.TurnEnd = null;
		GameBoard.CurrentState = GameBoard.GameState.Blue;
		SceneManager.LoadScene(s);
	}
	
	public void QuitGame () {
		Application.Quit();
	}
}
