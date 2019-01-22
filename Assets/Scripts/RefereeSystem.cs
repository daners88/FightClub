using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RefereeSystem : MonoBehaviour {
    public List<GameObject> player1Vulnerables;
    public List<GameObject> player2Vulnerables;
    public List<GameObject> player1Weapons;
    public List<GameObject> player2Weapons;
    public GameObject player1Health;
    public GameObject player2Health;
    private RectTransform p1health, p2health;
    private float healthBeginningValue;
    public List<AudioSource> hitSounds;
    public AudioSource catty;
    private int corrineStreak = 0;
    // Use this for initialization
    void Start () {
        RectTransform tempRectTransform = player1Health.GetComponent<RectTransform>();
        healthBeginningValue = tempRectTransform.rect.width;
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

                    var p1health = player1Health.transform as RectTransform;
                    p1health.sizeDelta = new Vector2(p1health.sizeDelta.x - 10, p1health.sizeDelta.y);
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

                    var p2health = player2Health.transform as RectTransform;
                    p2health.sizeDelta = new Vector2(p2health.sizeDelta.x - 10, p2health.sizeDelta.y);
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
