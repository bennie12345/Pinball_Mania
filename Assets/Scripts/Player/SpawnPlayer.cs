using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {
	Vector3 spawnPos;
	void Awake() {
		spawnPos = new Vector3(Random.Range(-5,5), transform.position.y, transform.position.z);
		transform.position = spawnPos;
	}	
}
