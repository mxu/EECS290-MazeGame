using UnityEngine;

public static class GameManager {
	public delegate void GameEvent();
	public static event GameEvent MazeBuilt;

	public static void TriggerMazeBuilt() {
		if(MazeBuilt != null) MazeBuilt();
		Debug.Log("Maze built");
	}
}
