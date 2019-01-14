using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public float minDist = 1;
    public float speed = 1;
    private GameObject Player; 
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("VrCamera");
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position, Player.transform.position) > minDist)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
        }
	}
}
