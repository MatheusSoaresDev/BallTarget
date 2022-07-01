using UnityEngine;
using System.Collections;

public class RandomBalls : MonoBehaviour {
	private int sorteador; // Variaveis de randomizaçao;
	private bool podesortear;// Variaveis de randomizaçao;

	public Transform blue; //Variavel de objeto a ser instanciado
	public Transform black; //Variavel de objeto a ser instanciado;
	public Transform red; //Variavel de objeto a ser instanciado;
	public Transform white; //Variavel de objeto a ser instanciado;
	public Transform yellow; //Variavel de objeto a ser instanciado;
	public Transform green; //Variavel de objeto a ser instanciado;

	public static int Score; // Variavel de contagem de pontuaçao;
	public GUIStyle pontos;

	public static float start; //Variavel de contagem regressiva para o começo do jogo; 
	public bool podecomecar;//Variavel de contagem regressiva para o começo do jogo;

	// Use this for initialization
	void Start () 
	{
		podesortear = true; //Variavel de contagem regressiva para o começo do jogo;
		podecomecar = false; //Variavel de contagem regressiva para o começo do jogo;
	}

	// Update is called once per frame
	void Update () 
	{
		Balls ();// Void Balls;
		start += 1 * Time.deltaTime; //Sistema de contagem regressiva;
		if (start > 8) //Sistema de contagem regressiva;
		{
			podecomecar = true;//Sistema de contagem regressiva;
			sorteador = (Random.Range (1, 7)); // sorteador de inicio;
		}
	}
	void Balls () 
	{
		if (sorteador == 1 && podesortear == true) // Instanciar objeto;
		{
			Instantiate(blue);// Instanciar objeto;
			podesortear = false;
		}
		if (sorteador == 2 && podesortear == true)// Instanciar objeto; 
		{
			Instantiate(black);// Instanciar objeto;
			podesortear = false;
		}
		if (sorteador == 3 && podesortear == true) // Instanciar objeto;
		{
			Instantiate(red);// Instanciar objeto;
			podesortear = false;
		}
		if (sorteador == 4 && podesortear == true)// Instanciar objeto; 
		{
			Instantiate(white);// Instanciar objeto;
			podesortear = false;
		}
		if (sorteador == 5 && podesortear == true) // Instanciar objeto;
		{
			Instantiate(yellow);// Instanciar objeto;
			podesortear = false;
		}
		if (sorteador == 6 && podesortear == true) // Instanciar objeto;
		{
			Instantiate(green);// Instanciar objeto;
			podesortear = false;
		}
		if (Input.GetMouseButtonDown (0) && podecomecar == true)// Clique para lançar a bola; 
		{
			podesortear = true;
			sorteador = (Random.Range (1, 6));
			//print (sorteador);
		}
	}
	void OnGUI ()
	{

	}
}