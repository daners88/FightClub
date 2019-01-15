using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {

    public float speed = 3;
    public float minDist = 3;
    GameObject randomSpot;
    GameObject originalSpot;
    float randx, randy = 1, randz;
    bool flag;
    // Use this for initialization
    void Start () {
        flag = true;
        originalSpot = new GameObject();
        randomSpot = new GameObject();
        originalSpot.transform.position = transform.position;
        randx = Random.Range(-10, 10);
        randz = Random.Range(-10, 10);
        Vector3 newPos = new Vector3(randx, randy, randz);
        randomSpot.transform.position = newPos; ;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, randomSpot.transform.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, randomSpot.transform.position) < minDist)
            {
                flag = !flag;
            
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, originalSpot.transform.position, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, originalSpot.transform.position) < minDist)
            {
                flag = !flag;
                randx = Random.Range(-10, 10);
                randz = Random.Range(-10, 10);
                Vector3 newPos = new Vector3(randx, randy, randz);
                randomSpot.transform.position = newPos; ;
            }
        }

    }
}
