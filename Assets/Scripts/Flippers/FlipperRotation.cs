using UnityEngine;
using System.Collections;

public class FlipperRotation : MonoBehaviour {
	[SerializeField]private GameObject[] flippers;

	public void Rotate(bool left, bool right) {
		if(left) {
			flippers[0].GetComponent<Rigidbody>().AddForce(new Vector3(0,1000,0));
		}else {
			flippers[0].GetComponent<Rigidbody>().AddForce(new Vector3(0,-1000,0));
		}

		if(right) {
			flippers[1].GetComponent<Rigidbody>().AddForce(new Vector3(0,1000,0));
		}else {
			flippers[1].GetComponent<Rigidbody>().AddForce(new Vector3(0,-1000,0));
		}

	}
}
