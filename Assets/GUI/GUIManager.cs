using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {


	//Displayed at the start as the loading screen.
	void OnGUI () {
		if(GUI.Button(new Rect(30,30,150,30), "Start Game")){
			GameManager.TriggerGameStart();
		}
	}

	//Called when the game is started
	private void GameStart () {

	}

	//Called on game over
	private void GameOver () {

	}
}
