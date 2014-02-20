using UnityEngine;
using System.Collections;

public static class GameManager {
	public delegate void GameEvent();
	public static event GameEvent MazeBuilt;

	//Number of monsters spawn
	private static int numberOfMonsters = -1;
	
	public static void TriggerMazeBuilt() {
		if(MazeBuilt != null) MazeBuilt();
	}

	//Starts the game
	public static void TriggerGameStart(){
		Application.LoadLevel("Maze");
	}

	//Spawn Monsters on map
	public static void TriggerMonsterSpawn(Transform spawnCell, float sizeOfGrid, GameObject monsterPrefab){
		if(numberOfMonsters == -1){
			numberOfMonsters = (int)sizeOfGrid/2;
			Debug.Log(numberOfMonsters);
		}
		if(Random.Range(0, 10)%2 == 0){
			if(numberOfMonsters > 0){
				GameObject.Instantiate(monsterPrefab, new Vector3(spawnCell.position.x, 0.5f, spawnCell.position.z), Quaternion.identity);
				numberOfMonsters--;
				Debug.Log("Monster spawned");
			}
			else{
			}
		}

	}


}
