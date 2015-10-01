using UnityEngine;
using System.Collections;

public class Intro_script : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Menu");
    }

    #if UNITY_EDITOR
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Application.LoadLevel("Menu");
            }
        }
    #endif
}
