using UnityEngine;
using System.Collections;

public class BallPlayer : MonoBehaviour 
{
	public float vel; //Variavel para bola do jogador andar para esquerda e para direita;
	public int EsquerdaDireita;

	public bool podeandardireita; //Variavel para bola do jogador andar para esquerda e para direita; 
	public bool podeandaresquerda;//Variavel para bola do jogador andar para esquerda e para direita; 
	public Rigidbody2D forca; // Variavel de fisica para lançar a bola do jogador;

	// Use this for initialization
	void Start () 
	{
		forca = GetComponent<Rigidbody2D> (); // Variavel de fisica para lançar a bola do jogador;
		vel = 20;//Variavel para bola do jogador andar para esquerda e para direita;
		EsquerdaDireita = (Random.Range(1, 3)); // Sorteia o numero para definir se a variavel EsquerdaDireita vai ser true ou false;

		if(EsquerdaDireita == 1) //Recebe o valor da variavel EsquerdaDireita;
		{
			podeandardireita = true;
			podeandaresquerda = false;
		}else{
			podeandardireita = false;
			podeandaresquerda = true;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		// script para fazer a bola do jogador andar da esquerda para direita;
		if (podeandardireita == true) 
		{
			transform.position += new Vector3 (vel * Time.deltaTime, 0, 0); // Se a variavel for verdadeira a bola pode ganhar velocidade para direita;
		}
		if (podeandaresquerda == true) 
		{
			transform.position -= new Vector3(vel * Time.deltaTime,0,0);// Se a variavel for verdadeira a bola pode ganhar velocidade para esquerda;
		}
		Control ();// executa a void da bola do jogador;
	}
	void OnGUI ()
	{

	}
	void OnTriggerEnter2D (Collider2D coll)
	{
		// script para fazer a bola do jogador andar da esquerda para direita;
		if (coll.gameObject.tag == "ParedeDireita") 
		{
			podeandardireita = false; //Quando a bola colidir com a parede direita a variavel se torna falsa;
		}
		if (podeandardireita == false) 
		{
			podeandaresquerda = true; // Quando a variavel se tornar falsa, a variavel pode andar esquerda se torna true;
		}
		if (coll.gameObject.tag == "ParedeEsquerda") 
		{
			podeandaresquerda = false; //Quando a bola colidir com a parede esquerda a variavel se torna falsa;
		}
		if (podeandaresquerda == false) 
		{
			podeandardireita = true; // Quando a variavel se tornar falsa, a variavel podeandardireita se torna verdadeira;
		}
	}
	void OnTriggerExit2D (Collider2D colisao)
	{

	}

	void Control ()
	{
		// Script para lançar a bola do jogador;
		if (Input.GetMouseButtonDown (0)) 
		{
			forca.velocity += new Vector2 (0, 50);// Quando jogador aperta o botao esquerdo do mouse a bola ganha velocidade no eixo y;
			vel = 0; // Quando jogador aperta o botao esquerdo do mouse a variavel retorna a zero para que possa ganhar velocidade no eixo y;
		}
		if (transform.position.y > 5.3f) 
		{
			Destroy(gameObject); // Quando a altura for maior que 5.3 o objeto se destroi dando lugar a outro;
		}
	}
}
