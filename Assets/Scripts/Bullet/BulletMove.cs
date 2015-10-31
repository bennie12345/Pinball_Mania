using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	float movementSpeed = 50.0f;
	void Update() {
		Move();
	}

	void Move() {
		transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
	}
}
