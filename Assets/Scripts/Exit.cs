using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour 
{

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
		transform.localScale += new Vector3 (0.2f, 0.2f, 0.2f);
		Application.Quit ();
	}
}
