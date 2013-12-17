using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour
{
	public Texture background;
	public int acc = (GameManager.Hit * 100) /GameManager.Shot;
	public float accuracy = (GameManager.Hit * 100) /GameManager.Shot;

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), background);
		GUI.Label(new Rect((Screen.width/2) - 120, 30, 300, 200), "CONGRATULATIONS!!! Earth has been saved");
		GUI.Label(new Rect((Screen.width/2) - 120, 55, 300, 200), "You Scored: " + GameManager.Score);
		GUI.Label(new Rect((Screen.width/2) - 120, 70, 300, 200), "Total Shots = " + GameManager.Shot + " : Total Hit = " + GameManager.Hit + " Accuracy = " + accuracy + "%");
		GUI.Label(new Rect((Screen.width/2) - 120, 95, 300, 200), "Total Score: Score * Accuracy = " + (GameManager.Score/100) * accuracy);
		//GUI.Label(new Rect((Screen.width/2) - 120, 120, 300, 200), "Total Score: Score * Accuracy = " + (GameManager.Score/GameManager.Shot) * GameManager.Hit);

		if(GUI.Button(new Rect((Screen.width/2) - 100, Screen.height - 100 , 200, 50), "Main Menu"))
		{
			Application.LoadLevel("MainMenu");
		}
	}	
}
