using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {
	
	
	public int MaxAsteroids = 3;
	public int CurrentAsteroids;
	
	public GameObject Asteroid;
	public float Timer = 0f;
	public float SpawnTime = .3f;
	
	// Update is called once per frame
	void Update () 
	{
		CurrentAsteroids = GameObject.FindGameObjectsWithTag("Asteroid").Length;
		
		if ( CurrentAsteroids < MaxAsteroids)
		{
			Timer += Time.deltaTime;
			if(Timer > SpawnTime)
			{
				Instantiate (Asteroid);
				Timer = 0f;
			}
		}
	}
}