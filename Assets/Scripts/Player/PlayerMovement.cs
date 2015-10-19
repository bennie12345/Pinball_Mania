using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private float speed = 5f;

    public void Move(float x)
    {
		transform.Translate(new Vector3(x * speed * Time.deltaTime, 0.0f, 0.0f), Space.Self);
//		GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
