﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //public GameObject startBtn;
    //public GameObject quitBtn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        SceneManager.LoadScene("CharacterSelect", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
