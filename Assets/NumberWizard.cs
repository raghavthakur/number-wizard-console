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

        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push UP = higher, Push DOWN = Lower, Push ENTER = Correct");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up Arrow key was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow key was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Enter key was pressed.");
        }
    }
}
