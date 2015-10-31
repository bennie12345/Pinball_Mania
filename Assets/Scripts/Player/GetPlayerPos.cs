using UnityEngine;
using System.Collections;

public class GetPlayerPos : MonoBehaviour {

	public Vector3 PlayerPos() {
		Vector3 playerPos = transform.position;
		return playerPos;
	}
}
