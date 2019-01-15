using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TrackerFollow : MonoBehaviour {

    public SteamVR_TrackedObject tracker;
    private Rigidbody rBody;

    // Use this for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        rBody.useGravity = false;
        rBody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        rBody.MovePosition(tracker.transform.position);
        rBody.MoveRotation(tracker.transform.rotation);
    }
}
