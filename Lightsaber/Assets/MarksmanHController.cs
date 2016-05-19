using UnityEngine;
using System.Collections;

public class MarksmanHController : MonoBehaviour {
    public GameObject Laser_Emitter;
    public GameObject Laser;
    public GameObject player;
    public float Laser_Forward_force;
    public AudioClip LaserSound;

    private AudioSource audioSource;


    // Use this for initialization
    void Start() {
        audioSource = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update() {
        Movement();

        if (Input.GetKeyDown("space")) {
            FireLaser();
        }
    }

    public void FireLaser() {
      
        
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(Laser, Laser_Emitter.transform.position, Laser_Emitter.transform.rotation) as GameObject;

        Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);
        Vector3 aimingTowards = new Vector3(player.transform.position.x + Random.Range(-0.1f, 0.1f), player.transform.position.y + Random.Range(-0.1f, 0.1f), player.transform.position.z + Random.Range(-0.1f, 0.1f));
        transform.LookAt(aimingTowards);

        Rigidbody temp_rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        temp_rigidbody.velocity = 1 * transform.forward * Laser_Forward_force;

        Destroy(Temporary_Bullet_Handler, 10.0f);

        audioSource.PlayOneShot(LaserSound, 1);
    }

    private void Movement() {
        transform.LookAt(player.transform);
        transform.position = (transform.position - player.transform.position).normalized * 1 + player.transform.position;
        transform.RotateAround(player.transform.position, Vector3.up, 10f * Time.deltaTime);
    }
}