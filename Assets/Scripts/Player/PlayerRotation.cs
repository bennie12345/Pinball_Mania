using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	float lookSensitivite = 10.0f;
	float smoothDamp = 0.1f;
	float zRotation;
	float currentZRotation;
	float zRotationV;
	void Update() {
		Rotate();
	}

	void Rotate(){
		zRotation += Input.GetAxis("Mouse X") * lookSensitivite;
		currentZRotation = Mathf.SmoothDamp(currentZRotation, zRotation, ref zRotationV, smoothDamp);
		transform.rotation = Quaternion.Euler(0,-90, zRotation);
	}
}
