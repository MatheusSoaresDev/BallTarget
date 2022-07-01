using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour 
{
	public string scene;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}
	void OnMouseDown ()
	{
		transform.localScale -= new Vector3 (0.2f, 0.2f, 0.2f);
	}
	void OnMouseUp ()
	{
		Application.LoadLevel (scene);
		transform.localScale += new Vector3 (0.2f, 0.2f, 0.2f);
	}
}
