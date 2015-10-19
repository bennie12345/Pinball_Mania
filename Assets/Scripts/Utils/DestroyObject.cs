using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyObject : MonoBehaviour {
	float destroyTime = 0;

	void Update () {
		if(transform.name == "Flash(Clone)") {
			DestroyAfterTime(0.2f, "Flash(Clone)");
		}

		if(transform.name == "Shootable") {

		}
	}

	void DestroyAfterTime(float maxTime, string name) {
		DestroyObject[] dos = GameObject.FindObjectsOfType<DestroyObject>();
		destroyTime+=Time.deltaTime;
		for(int i = 0; i < dos.Length; i++) {
			GameObject flash = GameObject.Find(name);
			List<GameObject> list = new List<GameObject>();
			list.Add(flash);
			for(int j = 0; j < list.Count; j++){
				if(destroyTime >= maxTime) {
					Destroy(list[j].gameObject);
				}
			}
		}
	}

	public void DestroyOb(GameObject coll){
		Destroy (coll.gameObject);
		
	}
}
