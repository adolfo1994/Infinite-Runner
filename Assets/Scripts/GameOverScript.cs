using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");
		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score*100);
		if (GUI.Button (new Rect (Screen.width / 2 - 40, 250, 100, 30), "Try Again?")) {
			Application.LoadLevel (0);
		}
	}
}
