using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EmissionCaller(Collision col)
    {
        transform.position = col.contacts[0].point;
        GetComponent<ParticleSystem>().Play(true);
    }
}
