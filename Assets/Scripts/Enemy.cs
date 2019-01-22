using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public float hitStrength = 6;
    private Slider enemyHp;
	// Use this for initialization
	void Start () {
        enemyHp = GameObject.Find("EnemyHpSlider").GetComponent<Slider>();
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
                gameObject.GetComponentInChildren<ParticleScript>().EmissionCaller(col);
                enemyHp.value -= 100;
            }
            else
            {
                print("smol hit");
                enemyHp.value -= 1;
            }
        }

        if(enemyHp.value == 0)
        {
            transform.position = new Vector3(4.5f, 4.5f, -5f);
            enemyHp.value = 1000;
        }
    }
}
