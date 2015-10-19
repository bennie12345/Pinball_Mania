using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {
	void OnTriggerEnter(Collider coll) {
		if(coll.transform.name == "Shootable") {
			Debug.Log("ok");
			DestroyObject dos = coll.GetComponent<DestroyObject>();
			dos.DestroyOb(coll.gameObject);
		}
	}
}
