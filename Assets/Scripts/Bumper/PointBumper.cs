using UnityEngine;
using System.Collections;

public class PointBumper : MonoBehaviour {
	Animator anim;
	void Awake() {
		anim = GetComponent<Animator>();
	}

	public void PlayAnim() {
		Debug.Log("hit");
		anim.Play("Expand");
	}
}
