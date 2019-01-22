﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RefereeSystem : MonoBehaviour {
    public List<GameObject> player1Vulnerables;
    public List<GameObject> player2Vulnerables;
    public List<GameObject> player1Weapons;
    public List<GameObject> player2Weapons;
   
    public List<AudioSource> hitSounds;
    public AudioSource catty;
    private int corrineStreak = 0;

    public Slider p1HealthFill, p2HealthFill;
    public float p1CurrentHealth, p2CurrentHealth;
    public float p1MaxHealth, p2MaxHealth;


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

                    p2CurrentHealth -= 10;
                    
                    ChangeHealth();
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

                    p1CurrentHealth -= 10;
                    
                    ChangeHealth();
                }
            }
        }
    }

    void ChangeHealth()
    {
        p1CurrentHealth = Mathf.Clamp(p1CurrentHealth, 0, p1MaxHealth);
        p2CurrentHealth = Mathf.Clamp(p2CurrentHealth, 0, p2MaxHealth);

        p1HealthFill.value = p1CurrentHealth / p1MaxHealth;
        p2HealthFill.value = p2CurrentHealth / p2MaxHealth;
    }

    void PlayRandomSound()
    {
        System.Random rand = new System.Random();
        int index = rand.Next(hitSounds.Count);
        hitSounds[index].Play();
    }
}
