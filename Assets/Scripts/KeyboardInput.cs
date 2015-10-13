using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	private FlipperRotation _fr;
	void Start () {
		_fr = GetComponent<FlipperRotation>();
	}

	void Update() {
		if(Input.GetKey(KeyCode.Q)) {
			_fr.Rotate(true, false);
		} 

		if(Input.GetKey(KeyCode.P)){
			_fr.Rotate(false, true);
		}
	}
}
