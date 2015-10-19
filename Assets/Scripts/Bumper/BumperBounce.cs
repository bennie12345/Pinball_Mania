using UnityEngine;
using System.Collections;

public class BumperBounce : MonoBehaviour {
	void Update() {
		GetDirection();
	}

	Vector3 GetDirection() {
		Vector3 player = GameObject.FindWithTag("Player").transform.position;
		Vector3 target = transform.position;
		Vector3 heading = target - player;
		float distance = heading.magnitude;
		Vector3 direction = heading / distance;

		return direction;
	}

	void OnCollisionEnter(Collision coll) {
		Debug.Log(-GetDirection());
	} 
}
