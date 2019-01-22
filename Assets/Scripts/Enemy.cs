using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float hitStrength = 6;
    public GameObject particleHit;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name.Contains("mixamorig"))
        {
            if (col.relativeVelocity.magnitude > hitStrength)
            {
                print("ya boi got hit");
                particleHit.GetComponent<ParticleScript>().EmissionCaller(col);
            }
            else
            {
                print("smol hit");
            }
        }

        /*
        if(enemyHp.value == 0)
        {
            transform.position = new Vector3(4.5f, 4.5f, -5f);
            enemyHp.value = 1000;
        }*/
    }
}
