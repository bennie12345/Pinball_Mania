using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	private FlipperRotation _fr;
	void Start () {
		_fr = GetComponent<FlipperRotation>();
	}

	void Update() {
		if(Input.GetKey(KeyCode.A)) {
			_fr.Rotate(true, false);
		} 

		if(Input.GetKey(KeyCode.D)){
			_fr.Rotate(false, true);
		}
	}
}
