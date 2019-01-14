using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRighting : MonoBehaviour {

    private Rigidbody rBody;
    private float force = 5;
    private float offset = 2;
	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        Vector3 point = transform.TransformPoint(offset * Vector3.up);
        rBody.AddForceAtPosition(force * Vector3.up, point);
    }
}
