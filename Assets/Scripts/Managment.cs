﻿using UnityEngine;
using System.Collections;

public class Managment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("escape")) {//When a key is pressed down it see if it was the escape key if it was it will execute the code
			Application.Quit(); // Quits the game
		}
	}
}
