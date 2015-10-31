using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	FlipperRotation _fr;

	void Awake() {
		_fr = GetComponent<FlipperRotation>();
	}

	void Update () {
		if(transform.name == "Flippers") {
			Flipper();
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
