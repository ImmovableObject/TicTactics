using UnityEngine;

public class MatchManager : MonoBehaviour {

    public GameObject LeftMatcher;
	public GameObject MiddleMatcher;
    public GameObject RightMatcher;

	public GameBoard.PieceType L;
	public GameBoard.PieceType M;
    public GameBoard.PieceType R;


    void Start(){
       GameBoard.TurnStart += CheckMatch;
       GameBoard.TurnEnd += CheckMatch;
       GameBoard.TurnEnd += ResetDetectors;
    }
    public void CheckMatch(){

        L = LeftMatcher.GetComponent<MatchDetector>().MatchType;
        M = MiddleMatcher.GetComponent<MatchDetector>().MatchType;
        R = RightMatcher.GetComponent<MatchDetector>().MatchType;

		if(L == GameBoard.PieceType.X  && M == GameBoard.PieceType.O && R == GameBoard.PieceType.X){
			GameBoard.XWin();
		}
		if(L == GameBoard.PieceType.O  && M == GameBoard.PieceType.X && R == GameBoard.PieceType.O){
			GameBoard.OWin();
		}
	}

    public void ResetDetectors(){
        LeftMatcher.GetComponent<MatchDetector>().SetToEmpty();
        MiddleMatcher.GetComponent<MatchDetector>().SetToEmpty();
        RightMatcher.GetComponent<MatchDetector>().SetToEmpty();
    }
}