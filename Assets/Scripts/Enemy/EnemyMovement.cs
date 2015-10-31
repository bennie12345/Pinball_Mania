using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	[SerializeField]private GameObject[] leftPath;
	[SerializeField]private GameObject[] rightPath;
	private GameObject[] path;
	int next = 0;

	void Start() {
		int rand = Random.Range(0,2);
		if(rand == 0){
			path = rightPath;
		} else if (rand == 1) {
			path = leftPath;
		}
	}

	void Update() {
		FollowPath();
	}

	void FollowPath() {
		transform.position = Vector3.MoveTowards(transform.position, path[next].transform.position, 0.1f);
		if(transform.position == path[next].transform.position) {
			next++;
		}
	}
}
