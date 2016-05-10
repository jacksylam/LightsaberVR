using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class leftTrigger : MonoBehaviour {

	public SteamVR_TrackedObject trackedObj;
	public GameObject BlackHole;
	public GameObject CapsuleRED;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}

	void Update () {
		SteamVR_Controller.Device device = SteamVR_Controller.Input ((int)trackedObj.index);
		if(device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
		{
			Debug.Log ("You pulled the left Trigger!");
		}

		if (device.GetTouch (SteamVR_Controller.ButtonMask.Grip))
		{
			Debug.Log ("You have Pressed the LEFT grip");
		
		}

	}
}