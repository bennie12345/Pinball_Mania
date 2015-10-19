using UnityEngine;
using System.Collections;
using UnityEditor;
using System;

public class Settings : MonoBehaviour {
	
	void Start () {
		Physics.gravity = new Vector3(Physics.gravity.z, -4, Physics.gravity.z);
	}
}
