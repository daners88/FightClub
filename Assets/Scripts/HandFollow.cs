using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HandFollow : MonoBehaviour {

    public SteamVR_Behaviour_Pose hand;
    private Rigidbody rBody;

	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rBody.MovePosition(hand.transform.position);
        rBody.MoveRotation(hand.transform.rotation);
	}

    private void FixedUpdate()
    {
        
    }
}
