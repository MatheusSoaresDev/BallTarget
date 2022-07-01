using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour 
{
	private float time;

	public string level1;
	public string level2;
	public string level3;
	public string level4;
	public string level5;
	public string level6;
	public string level7;
	public string level8;
	public string level9;
	public string level10;
	
	public int Sorted;
	// Use this for initialization
	void Start () 
	{

	}
	// Update is called once per frame
	void Update () 
	{
		if (Sorted == 1) 
		{
			Application.LoadLevel(level1);
		}
		if (Sorted == 2) 
		{
			Application.LoadLevel(level2);
		}
		if (Sorted == 3) 
		{
			Application.LoadLevel(level3);
		}
		if (Sorted == 4) 
		{
			Application.LoadLevel(level4);
		}
		if (Sorted == 5) 
		{
			Application.LoadLevel(level5);
		}
		if (Sorted == 6) 
		{
			Application.LoadLevel(level6);
		}
		if (Sorted == 7) 
		{
			Application.LoadLevel(level7);
		}
		if (Sorted == 8) 
		{
			Application.LoadLevel(level8);
		}
		if (Sorted == 9) 
		{
			Application.LoadLevel(level9);
		}
		if (Sorted == 10) 
		{
			Application.LoadLevel(level10);
		}

		time += 1 * Time.deltaTime;

		if (time > 4) 
		{
			Sorted = (Random.Range (1, 11));
		}
		print (time);
	}
}
