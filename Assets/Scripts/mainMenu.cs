using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour
{
	void OnGUI()
	{
		//reset variables for new game
		GameManager.Lives = 3;
		GameManager.Score = 0;
		GameManager.Hit = 0;
		GameManager.Shot = 0;
		GameManager.time = 30f;
		CatcherScript.counter = 0;

		GUI.Label(new Rect((Screen.width/2) - 100, 10, 300, 220), "Instructions\n" +
			"Press Left & Right arrow keys to move\n" +
			"Left Click mouse to shoot\n" +
			"Shoot asteroids for 100 points\n" +
			"Earth will take damage if hit by asteroids\n" +
			"8 times and Earth will be destroyed\n" +
			"Lose lives when asteroids hit the player\n" +
			"Lose 50 points when you lose a life\n" +
			"Game Over when out of lives or Earth is destroyed\n" +
			"Protect Earth for 30 seconds to Win!");	
		if(GUI.Button(new Rect((Screen.width/2) - 100, 250 , 200, 50), "Play Game"))
		{
			Application.LoadLevel("Game");	
		}
		
	}
	
}

