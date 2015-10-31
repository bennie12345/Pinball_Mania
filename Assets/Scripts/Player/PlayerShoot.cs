using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	[SerializeField]private GameObject bulletPrefab;
	[SerializeField]private GameObject nozzle;
	[SerializeField]private GameObject flash;
//	private float wait = 0.5f; 

	public void Shoot() {
//		for(int i = 0; i < 3;) {
			Instantiate(bulletPrefab, nozzle.transform.position, nozzle.transform.rotation);
			GameObject f = Instantiate(flash, nozzle.transform.position, nozzle.transform.rotation) as GameObject;
			f.transform.parent = transform;
//			wait = 0f;
//		}
	}	
}
