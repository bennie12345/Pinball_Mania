using UnityEngine;
using System.Collections;

public class MousePos : MonoBehaviour {
	public Vector3 Pos (float x, float y, float z) {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		Vector3 pos = Vector3.zero;
		if(Physics.Raycast(ray, out hit, Mathf.Infinity)) {
			pos = hit.point;
		}

		return new Vector3(pos.x + x, pos.y + y, pos.z + z);
	}	
}
