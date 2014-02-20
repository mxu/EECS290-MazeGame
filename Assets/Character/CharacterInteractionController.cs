using UnityEngine;
using System.Collections;

public class CharacterInteractionController : MonoBehaviour {

	//Happens when a monsters attacks a player
	void OnTriggerEnter(Collider col){
		Debug.Log("Collide!");
		if(col.gameObject.CompareTag("Monster")){
			dealDamage(.5f);
			Debug.Log ("The player has been hit!");
		}
	}

	//Deals damage to the player
	static void dealDamage(float damage){
		HealthBar.progress -= damage;
	}

}
