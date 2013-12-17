using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
	public int Speed = 10;

	void Update () 
	{
		transform.Translate (Vector3.up * Time.deltaTime * 10);
	}
}
