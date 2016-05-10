using UnityEngine;
using System.Collections;

public class Lightsaber : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("Laser")) {
            Rigidbody temp_rigidbody = other.GetComponent<Rigidbody>();
            temp_rigidbody.velocity = -1 * temp_rigidbody.velocity.magnitude * temp_rigidbody.velocity;
        }
    }
}
