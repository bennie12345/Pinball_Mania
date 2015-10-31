using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UploadScore : MonoBehaviour {
	int score;
	string uname;
	[SerializeField]private Text text;
	void Start() {
		score = PlayerPrefs.GetInt("Score");
		uname = PlayerPrefs.GetString("Username");
		WWWForm form = new WWWForm();
		form.AddField("Score", score);
		form.AddField("Name", uname);
		WWW www = new WWW("http://www.joeywelvaadt.com/pinball.php", form);
		StartCoroutine(WaitForRequest(www));
	}	

	IEnumerator WaitForRequest(WWW www) {
		yield return www;
		if(www.error == null) {
			Debug.Log("OK: " + www.text);
		} else {
			Debug.Log("Error: " + www.error);
		}
		text.text = www.text;
	}
}
