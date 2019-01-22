using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public float minDist = 1;
    public float speed = 1;
    private GameObject Player; 
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Ryan");
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position, Player.transform.position) > minDist)
        {
            if(Vector3.Distance(transform.position, Player.transform.position) > 5)
            {
                speed = 5;
            }
            else
            {
                speed = 2;
            }
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position + new Vector3(0,2f,0), speed * Time.deltaTime);
            print(Vector3.Distance(transform.position, Player.transform.position));
        }
	}
}
