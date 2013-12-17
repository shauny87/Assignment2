using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static int Lives = 3;
	public static int Score = 0;
	public static int Hit = 0;
	public static int Shot = 0;
	public static float time = 30f;

	void OnGUI()
	{
		GUI.Label(new Rect(5, 5, 200, 30), "Score: " + Score);
		GUI.Label(new Rect(5, 20, 200, 30), "Lives: " + Lives);
		GUI.Label(new Rect(5, 35, 200, 30), "Time: " + (int) time);
	}

	void Update()
	{
		time -= (Time.deltaTime);
	}

	public static void GameOver()
	{
		Application.LoadLevel("Lose");
	}
}
