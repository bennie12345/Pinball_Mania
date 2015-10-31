using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {
	private GameObject target;
	private bool useZoom = false;

	public GameObject Target {
		get {
			return target;
		} 

		set {
			target = value;
		}
	}

	public bool UseZoom {
		get {
			return useZoom;
		}
		set {
			useZoom = value;
		}
	}

	void Update () {
		if(useZoom) {
			Zoom();
		}
	}

	void Zoom() {
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, target.transform.position.z - 5), 0.05f);
	}	
}
