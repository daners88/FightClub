using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RefereeSystem : MonoBehaviour {
    public List<GameObject> player1Vulnerables;
    public List<GameObject> player2Vulnerables;
    public List<GameObject> player1Weapons;
    public List<GameObject> player2Weapons;
    public List<AudioSource> hitSounds;
    public AudioSource catty;
    private int corrineStreak = 0;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		foreach(var weapon in player1Weapons)
        {
            foreach(var vulnerable in player2Vulnerables)
            {
                if(weapon.GetComponent<BoxCollider>().bounds.Intersects(vulnerable.GetComponent<BoxCollider>().bounds))
                {
                    corrineStreak = 0;
                    PlayRandomSound();
                }
            }   
        }

        foreach (var weapon in player2Weapons)
        {
            foreach (var vulnerable in player1Vulnerables)
            {
                if (weapon.GetComponent<BoxCollider>().bounds.Intersects(vulnerable.GetComponent<BoxCollider>().bounds))
                {
                    corrineStreak++;
                    if(corrineStreak > 3)
                    {
                        catty.Play();
                    }
                    else
                    {
                        PlayRandomSound();
                    }
                }
            }
        }
    }

    void PlayRandomSound()
    {
        System.Random rand = new System.Random();
        int index = rand.Next(hitSounds.Count);
        hitSounds[index].Play();
    }
}
