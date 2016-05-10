using UnityEngine;
using System.Collections;

public class MarksmanHController : MonoBehaviour {
    public GameObject Laser_Emitter;
    public GameObject Laser;
    public float Laser_Forward_force;
	private float timer = 0.1f;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space")) {
            fireLaser();
        }
    }

    public void fireLaser() {
		if (timer < 0) {	
			GameObject Temporary_Bullet_Handler;
			Temporary_Bullet_Handler = Instantiate (Laser, Laser_Emitter.transform.position, Laser_Emitter.transform.rotation) as GameObject;

			Temporary_Bullet_Handler.transform.Rotate (Vector3.left * 90);

			Rigidbody temp_rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody> ();
			temp_rigidbody.velocity = 1
				* transform.forward * Laser_Forward_force;

			Destroy (Temporary_Bullet_Handler, 10.0f);
			timer = 0.1f;
		} else
			timer = timer - Time.deltaTime;
    }
}