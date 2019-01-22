using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GetCorrectController : MonoBehaviour {

    public bool rightHand = false;
	// Use this for initialization
	void Start () {
        uint leftIndex = OpenVR.System.GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole.LeftHand);
        uint rightIndex = OpenVR.System.GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole.RightHand);
        uint index = leftIndex;
        if(rightHand)
        {
            index = rightIndex;
        }
        GetComponent<SteamVR_TrackedObject>().index = (SteamVR_TrackedObject.EIndex)index;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
