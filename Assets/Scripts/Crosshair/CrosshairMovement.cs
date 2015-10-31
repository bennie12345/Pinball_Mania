using UnityEngine;
using System.Collections;

public class CrosshairMovement : MonoBehaviour {
	private MousePos _mp;

	void Awake() {
		_mp = GetComponent<MousePos>();
	}

	void Update() {
//		Debug.Log(_mp.Pos());
		transform.position = _mp.Pos(0,0,-2);
	}

}
