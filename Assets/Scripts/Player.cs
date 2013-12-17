using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public int Speed = 10;
	public GameObject Missile;	

	void Update ()
	{
		if (Input.GetAxis("Horizontal") != 0)
		{
			Move ();	
		}
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot ();
		}
		if(GameManager.time <= 0)
		{
			Application.LoadLevel("Win");
		}
		if(GameManager.Score < 0)
		{
			GameManager.Score = 0;
		}
	}
	
	void Move()
	{
		float LeftRightMovemet = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		transform.Translate (LeftRightMovemet,0,0);
	}
	
	void Shoot()
	{
		Instantiate(Missile, this.transform.position, this.transform.rotation);
		GameManager.Shot++;
	}

	public void Die()
	{
		GameManager.GameOver();
	}
}