using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int maxGuess = 1000;
        int minGuess = 1;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number you can choose is: " + maxGuess);
        Debug.Log("The lowest number you can choose is: " + minGuess);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
