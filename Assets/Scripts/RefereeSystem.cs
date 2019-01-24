using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public float hitStrength = 6;
    public GameObject particleHit;

    float p1LastHit, p2LastHit;
    bool p1CanHit, p2CanHit;


    // Use this for initialization
    void Start () {
        p1LastHit = Time.time;
        p1CanHit = true;
        p2LastHit = Time.time;
        p2CanHit = true;
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
        if(p1CanHit)
        {
            foreach (var weapon in player1Weapons)
            {
                foreach (var vulnerable in player2Vulnerables)
                {
                    if (weapon.GetComponent<BoxCollider>().bounds.Intersects(vulnerable.GetComponent<BoxCollider>().bounds))
                    {
                        particleHit.GetComponent<ParticleScript>().EmissionCaller(weapon.GetComponent<BoxCollider>().bounds.ClosestPoint(vulnerable.GetComponent<BoxCollider>().bounds.center));
                        corrineStreak = 0;
                        PlayRandomSound();

                        p2CurrentHealth -= 10;


                        ChangeHealth();
                        p1CanHit = false;
                        p1LastHit = Time.time;
                    }
                }
            }
        }
        else if(Time.time - p1LastHit > 1)
        {
            p1CanHit = true;
        }

        //if(p2CanHit)
        //{
        //    foreach (var weapon in player2Weapons)
        //    {
        //        foreach (var vulnerable in player1Vulnerables)
        //        {
        //            if (weapon.GetComponent<BoxCollider>().bounds.Intersects(vulnerable.GetComponent<BoxCollider>().bounds))
        //            {
        //                corrineStreak++;
        //                if (corrineStreak > 3)
        //                {
        //                    catty.Play();
        //                }
        //                else
        //                {
        //                    PlayRandomSound();
        //                }

        //                p1CurrentHealth -= 10;

        //                ChangeHealth();
        //                p2CanHit = false;
        //                p2LastHit = Time.time;
        //            }
        //        }
        //    }
        //}
        //else if (Time.time - p2LastHit > 1)
        //{
        //    p2CanHit = true;
        //}
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
