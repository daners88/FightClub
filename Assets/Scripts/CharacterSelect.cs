using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

    // Use this for initialization
    GameObject[] characterButtons;
	void Start () {
        characterButtons = GameObject.FindGameObjectsWithTag("characterButton");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void selectCharacter(GameObject btn)
    {
        foreach(var character in characterButtons)
        {
            if(btn == character)
            {
                btn.GetComponent<Button>().interactable = false;
            }
            else
            {
                btn.GetComponent<Button>().interactable = true;
            }
        }
    }

    public void back()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }

    public void confirm()
    {
        SceneManager.LoadScene("FightClub", LoadSceneMode.Single);
    }
}
