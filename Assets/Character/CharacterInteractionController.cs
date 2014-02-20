using UnityEngine;
using System.Collections;

public class CharacterInteractionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter(Collision col){
		if(col.transform.tag == "Monster"){
			dealDamage(.5f);
			Debug.Log ("The player has been hit!");
		}
	}

	//Deals damage to the player
	static void dealDamage(float damage){
		HealthBar.progress -= damage;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
