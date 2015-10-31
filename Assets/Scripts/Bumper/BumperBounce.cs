using UnityEngine;
using System.Collections;

public class BumperBounce : MonoBehaviour {

	Vector3 GetDirection() {
		Vector3 player = GameObject.FindWithTag("Player").transform.position;
		Vector3 target = transform.position;
		Vector3 heading = target - player;
		float distance = heading.magnitude;
		Vector3 direction = heading / distance;

		return direction;
	}

	void OnCollisionEnter(Collision coll) {
		if(coll.transform.name != "Enemy(Clone)") {
			if(transform.name == "ReverseBumperY") {
				coll.rigidbody.AddForce(new Vector3(-GetDirection().x * 2000, (-GetDirection().y - (-GetDirection().y * 2)) * 1000 , GetDirection().z * 1000));
			} else if(transform.name == "ReverseBumperX") {
				coll.rigidbody.AddForce(new Vector3(GetDirection().x * 1000, (GetDirection().y - (GetDirection().y * 2)) * 1000 , -GetDirection().z * 1000));
			} else {
				coll.rigidbody.AddForce(new Vector3(-GetDirection().x * 1000, (GetDirection().y - (GetDirection().y * 2)) * 1000 , -GetDirection().z * 1000));
			}
		}
	} 
}
