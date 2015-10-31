using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHighscores : MonoBehaviour {
	[SerializeField]private GameObject highscores;
	public void Show() {
		highscores.SetActive (true);
	}	

	void Update() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			highscores.SetActive (false);
		}
	}
}
