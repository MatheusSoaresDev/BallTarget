﻿using UnityEngine;
using System.Collections;

public class YellowTarget : MonoBehaviour 
{
	public static RandomBalls instance;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "yellow") 
		{
			RandomBalls.Score += 1;
			Destroy (gameObject);
		}
	}
}
