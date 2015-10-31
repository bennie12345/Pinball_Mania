using UnityEngine;
using System.Collections;

public class CheckCollision : MonoBehaviour {
	[SerializeField]private GameObject deathParticle;
	void OnTriggerEnter(Collider coll) {
		var tag = coll.transform.tag;
		var name = coll.transform.name;



		if(name == "Enemy(Clone)" && transform.name == "Bullet(Clone)") {
			DestroyObject dos = coll.GetComponent<DestroyObject>();
			GetScore gs = GameObject.Find("ScoreManager").GetComponent<GetScore>();
			dos.DestroyOb(coll.gameObject);
			gs.IncreaseScore();
			deathParticle = null;
		}

		if(tag == "Player" && this.transform.name == "Deathzone") {
			CameraZoom cz = Camera.main.GetComponent<CameraZoom>();
			Instantiate(deathParticle, coll.transform.position, coll.transform.rotation);
			cz.Target = deathParticle.gameObject;	
			cz.UseZoom = true;
			Destroy(coll.gameObject);
			Application.LoadLevel(2);
		}
	}

	void OnCollisionEnter(Collision coll) {
		PointBumper pb = gameObject.GetComponent<PointBumper>();
		pb.PlayAnim();

	
	}
}
