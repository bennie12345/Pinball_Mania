using UnityEngine;
using System.Collections;

public class MouseInput : MonoBehaviour {
	PlayerShoot ps;
	void Awake() {
		ps = GetComponent<PlayerShoot>();
	}

	void Update () {
		PlayerMouse();
	}

	void PlayerMouse(){
		if(Input.GetMouseButtonDown(0)) {
			ps.Shoot();
		}
	}
}
