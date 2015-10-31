using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Username : MonoBehaviour {
	private string uname;
	[SerializeField]private Text text;

	void Update() {
		uname = text.text;
		PlayerPrefs.SetString("Username", uname);
	}
}
