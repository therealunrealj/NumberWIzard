using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

	int min;
	int max;
	int guess;

	// Use this for initialization
	void Start () {
		int min = 1;
		int max = 1000;
		guess = 500;
		Debug.Log ("min: " + min + "max:" + max);
		StartGame ();
	}

	void StartGame () {
		Debug.Log ("Think of a number" + guess);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			calcGuess ();
		} 

		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			calcGuess ();
		}

		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			max = 0;
			Debug.Log ("Guessed right");

		}
			
	}
	void calcGuess () {
		guess = (min + max)/2;
		Debug.Log("Is the number equal to, higher or lower than" + guess + "?");
	}
}