using UnityEngine;

public class monsterAnimator : MonoBehaviour {
	

	private float runSpeed = .02f;
	private float walkSpeed = .01f;
	private float turnSpeed = .005f;
	private float timer = 3f;
	private GameObject floor = null;

	// Use this for initialization
	void Start () {
		floor = GameObject.Find("Floor");
		transform.position = new Vector3(200, floor.transform.position.y + 1, 120);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject FPS = GameObject.Find ("FPS");
		if (((FPS.transform.position.x - transform.position.x) <= 1) && ((FPS.transform.position.x - transform.position.x) >=-1)  && ((FPS.transform.position.z - transform.position.z) <=1) && ((FPS.transform.position.z - transform.position.z) >= -1)){
			animation.Play("bitchslap");
			
		}
		else{
			if (((FPS.transform.position.x - transform.position.x) <= 10) && ((FPS.transform.position.x - transform.position.x) >=-10)  && ((FPS.transform.position.z - transform.position.z) <=10) && ((FPS.transform.position.z - transform.position.z) >= -10)){
				animation.Play ("run");
				transform.position = Vector3.Lerp(transform.position, (new Vector3(FPS.transform.position.x, floor.transform.position.y + 1, FPS.transform.position.z)), runSpeed);
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
