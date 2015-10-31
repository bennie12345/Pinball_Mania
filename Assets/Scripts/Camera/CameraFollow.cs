using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	GetPlayerPos _gps;
	void Awake() {
		_gps = GameObject.FindObjectOfType<GetPlayerPos>();
	}

	void Update() {
		transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),new Vector3(_gps.PlayerPos().x, _gps.PlayerPos().y, transform.position.z), 1.5f);
	}
}
