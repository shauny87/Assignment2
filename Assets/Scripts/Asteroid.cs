using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public int Speed = 1;
	public GameObject explosion;
	
	void Start () 
	{
		Vector3 StartPosition = new Vector3(Random.Range (-10f, 10f), 11, 0);
		transform.position = StartPosition;
	}

	void Update () 
	{
		transform.Translate (Vector3.down * Time.deltaTime * Speed);
	}
	
	void OnTriggerEnter (Collider other)
	{
		if ( other.tag == "Missile" )	
		{
			Debug.Log("Asteroid shot");
			Destroy (other.gameObject);
			Destroy (gameObject);
			Instantiate(explosion, this.transform.position, this.transform.rotation);
			GameManager.Score += 100;
			GameManager.Hit++;
		}

		else if(other.tag == "Player")
		{
			Debug.Log("Player Hit");
			GameManager.Lives --;
			Destroy (gameObject);
			Instantiate(explosion, this.transform.position, this.transform.rotation);
			GameManager.Score -= 50;
			
			if(GameManager.Lives == 0)
			{
				other.GetComponent<Player>().Die();
			}
		}
	}
}