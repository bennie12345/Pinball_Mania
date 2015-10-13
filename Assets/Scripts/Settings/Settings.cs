using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {
	
	void Start () {
		Physics.gravity = new Vector3(Physics.gravity.z, -4, Physics.gravity.z);
	}
}
