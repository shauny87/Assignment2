using UnityEngine;
using System.Collections;

public class CatcherScript : MonoBehaviour {
	public static int counter = 0;

	 void OnTriggerEnter ( Collider other)
	
	{
		print ( other.name);
		Destroy (other.gameObject);
		GameManager.Score -= 10;
		counter++;
		if(CatcherScript.counter == 8)
		{
			Application.LoadLevel("Lose");
		}
	}
}
		