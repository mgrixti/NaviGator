﻿using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
    public GameObject mainMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void newGame_onClick()
    {
        //Start New Game jump to scene 1
        mainMenu.SetActive(false);
        Application.LoadLevel(1);
    }
    public void options_onClick()
    {
        //Option pop-up here
    }
    public void quit_onClick()
    {
        Application.Quit();
    }
}
