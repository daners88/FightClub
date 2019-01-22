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

    public void EmissionCaller(Vector3 col)
    {
        transform.position = col;
        GetComponent<ParticleSystem>().Play(true);
    }
}
