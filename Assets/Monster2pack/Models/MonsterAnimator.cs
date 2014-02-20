using UnityEngine;

public class MonsterAnimator : MonoBehaviour {
	
	
	private float runSpeed = .02f;
	private float walkSpeed = .01f;
	private float turnSpeed = .005f;
	private float timer = 3f;
	
	// Use this for initialization
	void Start () {
		transform.localScale -= new Vector3(.8f, .8f, .8f);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject FPS = GameObject.Find ("First Person Controller(Clone)");
		if (((FPS.transform.position.x - transform.position.x) <= .1f) && ((FPS.transform.position.x - transform.position.x) >=-.1f)  && ((FPS.transform.position.z - transform.position.z) <=.1f) && ((FPS.transform.position.z - transform.position.z) >= -.1f)){
			animation.Play("bitchslap");
			
		}
		else{
			if (((FPS.transform.position.x - transform.position.x) <= 10) && ((FPS.transform.position.x - transform.position.x) >=-10)  && ((FPS.transform.position.z - transform.position.z) <=10) && ((FPS.transform.position.z - transform.position.z) >= -10)){
				animation.Play ("run");
				transform.position = Vector3.Lerp(transform.position, (new Vector3(FPS.transform.position.x, .5f, FPS.transform.position.z)), runSpeed);
				Vector3 targetPostition = new Vector3(FPS.transform.position.x, transform.position.y, FPS.transform.position.z);
				transform.LookAt(targetPostition);
			}
			else {
				animation.Play("walk");
				transform.Translate (Vector3.forward * walkSpeed);
				timer -= Time.deltaTime;
				int turnDegrees = Random.Range (0, 90);
				int turnDirection = Random.Range (0, 1);
				if (turnDirection == 1 && timer <0 ){
					transform.Rotate(Vector3.up * turnSpeed, turnDegrees);
					timer = 15;
				}
				else if (timer <= 0){
					transform.Rotate(Vector3.down * turnSpeed, turnDegrees);
					timer = 15;
				}
			}
		}
		
		
	}
	
}
