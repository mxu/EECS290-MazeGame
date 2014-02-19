using UnityEngine;

public class MonsterController : MonoBehaviour {
	
	public GameObject prefab;
	public int numMonsters;
	private GameObject floor = null;
	
	void Start() {
		floor = GameObject.Find("Floor");
		for (int i = 0; i < numMonsters; i++) {
			int xPos = Random.Range (10,110);
			int zPos = Random.Range (10,110);
			GameObject Monster = (GameObject) Instantiate(prefab, new Vector3(xPos, floor.transform.position.y + 1, zPos), Quaternion.identity);
			Monster.SetActive(true);
			Monster.name = "Monster " + i;
		}
	}
}
