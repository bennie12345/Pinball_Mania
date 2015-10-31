using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	private GameObject target;
	void Update() {

		Rotate();
	}
	
	void Rotate(){
		target = GameObject.Find("Crosshair");
		transform.LookAt(new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z));
	}
}
