using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {

	void Update () {
		if(Input.GetKey(KeyCode.A)) {
			GameObject flipper = GameObject.FindWithTag("Flipper");
			flipper.GetComponent<FlipperRotation>().Rotate(true, false);
		}

		if(Input.GetKey(KeyCode.L)) {
			GameObject flipper = GameObject.FindWithTag("Flipper");
			flipper.GetComponent<FlipperRotation>().Rotate(false, true);
		}

		if(Input.GetKey(KeyCode.Space)) {
			GameObject pin = GameObject.FindWithTag("Pin");
			pin.GetComponent<PinShoot>().Shoot();
		}
	}
}
