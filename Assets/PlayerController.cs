using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public static Transform player;

	// Use this for initialization
	void Start () {
//		GameManager.MazeBuilt += spawnPlayer;
	}

	//Spawns player
	public static void spawnPlayer(){
		Transform.Instantiate (player, new Vector3 (0, 5, 0), Quaternion.identity);
		Debug.Log ("spawning player");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
