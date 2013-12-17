using UnityEngine;
using System.Collections;

public class LoseScreen : MonoBehaviour
{
	public Texture background;
	public int acc = (GameManager.Hit * 100) /GameManager.Shot;
	public int accuracy = (GameManager.Hit * 100) /GameManager.Shot;

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height), background);

		if(GameManager.Lives == 0)
		{
			GUI.Label(new Rect((Screen.width/2) - 120, 30, 300, 200), "GAME OVER!!! Earth has been DESTROYED\n" + "You lost all your lives");
		}
		else if(CatcherScript.counter == 8)
		{
			GUI.Label(new Rect((Screen.width/2) - 120, 30, 300, 200), "GAME OVER!!! Earth has been DESTROYED\n" + "Earth took too much damage");
		}

		//GUI.Label(new Rect((Screen.width/2) - 120, 55, 300, 200), "You Scored: " + GameManager.Score);
		//GUI.Label(new Rect((Screen.width/2) - 120, 70, 300, 200), "Accuracy: " + accuracy + "%");
		//GUI.Label(new Rect((Screen.width/2) - 120, 95, 300, 200), "Total Score: Score * Accuracy = " + (GameManager.Score/100) * accuracy);
		GUI.Label(new Rect((Screen.width/2) - 120, 60, 300, 200), "You Scored: " + GameManager.Score);
		GUI.Label(new Rect((Screen.width/2) - 120, 75, 300, 200), "Total Shots = " + GameManager.Shot + " : Total Hit = " + GameManager.Hit + " Accuracy = " + accuracy + "%");
		GUI.Label(new Rect((Screen.width/2) - 120, 100, 300, 200), "Total Score: Score * Accuracy = " + (GameManager.Score/100) * accuracy);

		if(GUI.Button(new Rect((Screen.width/2) - 100, Screen.height - 100 , 200, 50), "Main Menu"))
		{
			Application.LoadLevel("MainMenu");
		}
	}	
}
