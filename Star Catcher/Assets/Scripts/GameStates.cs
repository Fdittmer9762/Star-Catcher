using UnityEngine;
using System.Collections;

public class GameStates : MonoBehaviour {

	public enum gameState {Start, Loading, Playing, Paused, GameOver, Ending}; 

	public static gameState currentGameState = gameState.Start;

	IEnumerator GameStateMachine (){
		switch (GameStates.currentGameState) {
		case gameState.Start:
			//things
			break;
		case gameState.Loading:
			//things
			break;
		case gameState.Playing:
			//things
			break;
		case gameState.Paused:
			//things
			break;
		case gameState.GameOver:
			//things
			break;
		case gameState.Ending:
			//things
			break;
		}
		yield return null;
		StartCoroutine (GameStateMachine());
	}


	void Start (){
		StartCoroutine (GameStateMachine ());
	}

}
