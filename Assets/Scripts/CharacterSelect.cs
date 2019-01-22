using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

    // Use this for initialization
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;
    public GameObject character6;
    void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void selectCharacter(GameObject btn)
    {
        if(btn == character1)
        {
            character1.GetComponent<Button>().interactable = false;
            character2.GetComponent<Button>().interactable = true;
            character3.GetComponent<Button>().interactable = true;
            character4.GetComponent<Button>().interactable = true;
            character5.GetComponent<Button>().interactable = true;
            character6.GetComponent<Button>().interactable = true;
        }
        else if(btn == character2)
        {
            character1.GetComponent<Button>().interactable = true;
            character2.GetComponent<Button>().interactable = false;
            character3.GetComponent<Button>().interactable = true;
            character4.GetComponent<Button>().interactable = true;
            character5.GetComponent<Button>().interactable = true;
            character6.GetComponent<Button>().interactable = true;
        }
        else if (btn == character3)
        {
            character1.GetComponent<Button>().interactable = true;
            character2.GetComponent<Button>().interactable = true;
            character3.GetComponent<Button>().interactable = false;
            character4.GetComponent<Button>().interactable = true;
            character5.GetComponent<Button>().interactable = true;
            character6.GetComponent<Button>().interactable = true;
        }
        else if (btn == character4)
        {
            character1.GetComponent<Button>().interactable = true;
            character2.GetComponent<Button>().interactable = true;
            character3.GetComponent<Button>().interactable = true;
            character4.GetComponent<Button>().interactable = false;
            character5.GetComponent<Button>().interactable = true;
            character6.GetComponent<Button>().interactable = true;
        }
        else if (btn == character5)
        {
            character1.GetComponent<Button>().interactable = true;
            character2.GetComponent<Button>().interactable = true;
            character3.GetComponent<Button>().interactable = true;
            character4.GetComponent<Button>().interactable = true;
            character5.GetComponent<Button>().interactable = false;
            character6.GetComponent<Button>().interactable = true;
        }
        else if (btn == character6)
        {
            character1.GetComponent<Button>().interactable = true;
            character2.GetComponent<Button>().interactable = true;
            character3.GetComponent<Button>().interactable = true;
            character4.GetComponent<Button>().interactable = true;
            character5.GetComponent<Button>().interactable = true;
            character6.GetComponent<Button>().interactable = false;
        }

    }

    public void back()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }

    public void confirm()
    {
        SceneManager.LoadScene("John", LoadSceneMode.Single);
    }
}
