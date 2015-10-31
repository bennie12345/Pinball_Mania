using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetScore : MonoBehaviour {
	private int score;
	[SerializeField]private Text scoreText;

	void Update() {
		scoreText.text = "Score: " + score;
	}

	public void IncreaseScore() {
		score += 10;
		Debug.Log(score);
		PlayerPrefs.SetInt("Score", score);
	}	
}
