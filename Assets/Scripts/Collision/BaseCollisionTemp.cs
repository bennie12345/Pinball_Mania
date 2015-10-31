using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BaseCollisionTemp : MonoBehaviour {
	int health = 30;
	[SerializeField]private Text healthText;

	void Update(){
		healthText.text = "Base health: " + health;
		if(health <= 0) {
			Application.LoadLevel(2);
		}
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
			health--;
            Destroy(other.gameObject);
        }
    }
}
