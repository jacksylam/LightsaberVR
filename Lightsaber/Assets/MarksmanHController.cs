using UnityEngine;
using System.Collections;

public class MarksmanHController : MonoBehaviour {
    public GameObject Laser_Emitter;
    public GameObject Laser;
    public GameObject player;
    public float Laser_Forward_force;


    // Use this for initialization
    void Start() {
        
       
    }

    // Update is called once per frame
    void Update() {
        transform.LookAt(player.transform);
        transform.RotateAround(player.transform.position, Vector3.up, 10f * Time.deltaTime);

        if (Input.GetKeyDown("space")) {
            fireLaser();
        }
    }

    public void fireLaser() {
      
        
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(Laser, Laser_Emitter.transform.position, Laser_Emitter.transform.rotation) as GameObject;

        Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
        Vector3 aimingTowards = new Vector3(player.transform.position.x + Random.Range(-0.1f, 0.1f), player.transform.position.y + Random.Range(-0.1f, 0.1f), player.transform.position.z + Random.Range(-0.1f, 0.1f));
        transform.LookAt(aimingTowards);

        Rigidbody temp_rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        temp_rigidbody.velocity = 1 * transform.forward * Laser_Forward_force;

        Destroy(Temporary_Bullet_Handler, 10.0f);
	
    }

    
}