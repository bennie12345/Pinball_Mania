using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	[SerializeField]private GameObject bulletPrefab;
	[SerializeField]private GameObject nozzle;
	[SerializeField]private GameObject flash;

	public void Shoot() {
		Instantiate(bulletPrefab, nozzle.transform.position, nozzle.transform.rotation);
		GameObject f = Instantiate(flash, nozzle.transform.position, nozzle.transform.rotation) as GameObject;
		f.transform.parent = transform;
	}	
}
