using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {
	[SerializeField]private GameObject[] _spawnPositions;
	[SerializeField]private GameObject ballPrefab;

	void Start() {
		Vector3 spawnPos = _spawnPositions[Random.Range(0, _spawnPositions.Length)].transform.position;
		Instantiate(ballPrefab, spawnPos, Quaternion.identity);
	}
}
