using UnityEngine;
using System.Collections;

public class LaserController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.ToString());
        if (other.gameObject.name.Equals("Ground")) {
            Destroy(gameObject);
        }
      
    }
}
