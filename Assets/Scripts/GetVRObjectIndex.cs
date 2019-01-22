﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GetVRObjectIndex : MonoBehaviour {

    public string trackerStr;
	// Use this for initialization
	void Start () {
        uint index = 0;
        var error = ETrackedPropertyError.TrackedProp_Success;
        for (uint i = 0; i < 16; i++)
        {
            var result = new System.Text.StringBuilder((int)64);
            OpenVR.System.GetStringTrackedDeviceProperty(i, ETrackedDeviceProperty.Prop_ControllerType_String, result, 64, ref error);
            if (result.ToString().Contains(trackerStr))
            {
                print(result);
                index = i;
                break;
            }
        }
        GetComponent<SteamVR_TrackedObject>().index = (SteamVR_TrackedObject.EIndex)index;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
