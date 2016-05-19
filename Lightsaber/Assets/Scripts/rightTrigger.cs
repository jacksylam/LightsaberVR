using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class rightTrigger : MonoBehaviour {

	public SteamVR_TrackedObject trackedObj;
    public GameObject MarkshmanH;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}

	void Update () {
		SteamVR_Controller.Device device = SteamVR_Controller.Input ((int)trackedObj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			Debug.Log ("You have pulled the RIGHT trigger");
            MarkshmanH.GetComponent<MarksmanHController>().FireLaser();

			
		}
		if (device.GetTouch (SteamVR_Controller.ButtonMask.Grip))
		{
			
			Debug.Log ("You have Pressed the RIGHT grip");
		}
	}
}