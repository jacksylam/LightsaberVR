using UnityEngine;
using System.Collections;

public class CameraDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {
            transform.localPosition = transform.position + transform.forward * 0.5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            transform.localPosition = transform.position - transform.right * 0.5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.localPosition = transform.position - transform.forward * 0.5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.localPosition = transform.position + transform.right * 0.5f * Time.deltaTime;

        }

	}
}
