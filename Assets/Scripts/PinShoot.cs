using UnityEngine;
using System.Collections;

public class PinShoot : MonoBehaviour {
	private Rigidbody _rb;
	public void Shoot(){
		if(_rb != null) {
			_rb.AddForce(new Vector3(0,0,1000));
		} else {

		}

	}

	void OnCollisionEnter(Collision coll) {
		if(coll.transform.tag == "Player") {
			_rb = coll.gameObject.GetComponent<Rigidbody>();
		}
	}
}
