using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	FlipperRotation _fr;
	PlayerMovement _pm;

	void Awake() {
		_fr = GetComponent<FlipperRotation>();
		_pm = GetComponent<PlayerMovement>();
	}

	void Update () {
		if(transform.name == "Flippers") {
			Flipper();
		}

		float x = Input.GetAxis("Horizontal");
		if(x != 0) {
			if(transform.name == "Player") {
				_pm.Move(x);
			}
		}
	}

	void Flipper(){
		if(Input.GetKey(KeyCode.A)) {
			_fr.Rotate(true,false);
		}

		if (Input.GetKey(KeyCode.D)) {
			_fr.Rotate(false,true);
		}
	}
}
