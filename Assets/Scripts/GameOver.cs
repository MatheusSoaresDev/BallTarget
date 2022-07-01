using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{
	public float time;
	// Use this for initialization
	void Start () 
	{
		time = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		time += 1 * Time.deltaTime;

		if (time > 4) 
		{
			Application.LoadLevel("Menu");
		}
	}
}
