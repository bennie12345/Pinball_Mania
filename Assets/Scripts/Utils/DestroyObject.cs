using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {
	float destroyTime = 0;

	void Update () {
		if(transform.name == "Flash(Clone)") {
			DestroyAfterTime(0.2f);
		}
	}

	void DestroyAfterTime(float maxTime) {
		DestroyObject[] dos = GameObject.FindObjectsOfType<DestroyObject>();
		destroyTime+=Time.deltaTime;
		for(int i = 0; i < dos.Length; i++) {
			if(destroyTime >= maxTime) {
				Destroy(dos[i].gameObject);
			}
		}
	}
}
