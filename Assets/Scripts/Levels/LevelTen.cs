using UnityEngine;
using System.Collections;

public class LevelTen : MonoBehaviour 
{
	private float time; // Variavel do cronometro que marca o tempo;
	private float TimeStart; // Variavel que marca a contagem regressiva antes do jogo comecar;
	
	public int contagem;
	public int contagemStart;
	
	public GUIStyle DefaultStyle;
	
	private GameObject TimePosition; // Game object para posicionamento do marcador de tempo;
	private GameObject GoPosition; // Game object para posicionamento da mensagem " GO! ";
	private GameObject TempoDeInicio; // Game object para posicionamento do marcador de contagem regressiva;
	private GameObject Missao; // Game object para posicionamento da mensagem que indica a missao;
	private GameObject score; // Game object para posicionamtento da pontuacao; 
	
	public static RandomBalls instance; // Instancia o script Random Balls;
	
	private bool Win; // Variavel que indica se o jogador cumpriu a missao;
	private bool Wrong; // Variavel que indica se o jogador nao cumpriu a missao;
	private bool MissaoUI; // Variavel que indica se a mensagem de missao vai aparecer ou sumir;
	private bool ContagemSome; // Variavel que indica se minha contagem regressiva vai sumir;  
	private bool GoSome; // variavel que indica se a mensagem de "GO!" vai sumir;
	
	private string Objective; //Variavel Missao;
	
	// Use this for initialization
	void Start () 
	{
		Objective = "Faça 45 pontos em 110 segundos"; // Valor da Variavel Missao
		
		//Game Objects de posicionamento da UI;
		TimePosition = GameObject.Find("Time"); // Game object para posicionamento do marcador de tempo;
		GoPosition = GameObject.Find ("MsgGo"); // Game object para posicionamento da mensagem " GO! ";
		TempoDeInicio = GameObject.Find("TempoDeInicio"); // Game object para posicionamento do marcador de contagem regressiva;
		Missao = GameObject.Find ("Missao"); // Game object para posicionamento da mensagem que indica a missao;
		score = GameObject.Find("Score"); // // Game object para posicionamento da mensagem que Conta a pontuacao;
		//Game Objects de posicionamento da UI;
		
		Win = false; // Valor da Variavel que indica se o jogador cumpriu a missao;
		Wrong = false;// Valor variavel que indica se o jogador nao cumpriu a missao;
		
		TimeStart = 0;  //Valor da Variavel que marca a contagem regressiva antes do jogo comecar;
		
		MissaoUI = true;
		
		ContagemSome = true;
		
		GoSome = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Win == true) 
		{
			Application.LoadLevel("Win");
		}
		if (Wrong == true) 
		{
			Application.LoadLevel("GameOver");
		}
		
		if(time - contagem > 1)
		{
			contagem +=1;
		}
		if(TimeStart - contagemStart > 1)
		{
			contagemStart +=1;
		}
		if (RandomBalls.start > 4) 
		{
			MissaoUI = false;
			TimeStart += 1 * Time.deltaTime;
			ContagemSome = false;
		}
		if (RandomBalls.start > 8) 
		{
			ContagemSome = true;
			time += 1*Time.deltaTime;
		}
		
		mission (); // Ativa a void mission;
	}
	void OnGUI ()
	{	
		if (MissaoUI == true) 
		{
			GUI.Label (new Rect (Missao.transform.position.x, Missao.transform.position.y, 100, 100), " " + Objective, DefaultStyle);
		}
		if (ContagemSome == false) 
		{
			GUI.Label (new Rect (TempoDeInicio.transform.position.x, TempoDeInicio.transform.position.y,100, 100), " " + contagemStart, DefaultStyle);
		}
		if (RandomBalls.start > 8 && GoSome == true) 
		{
			GUI.Label(new Rect(GoPosition.transform.position.x, GoPosition.transform.position.y,100,100), "GO! ", DefaultStyle);
		}
		if (RandomBalls.start > 9) 
		{
			GoSome = false;
		}
		
		GUI.Label(new Rect(score.transform.position.x,score.transform.position.y,100,100), "Score: " + RandomBalls.Score, DefaultStyle);// Mostra a pontuçao.
		GUI.Label (new Rect (TimePosition.transform.position.x, TimePosition.transform.position.y, 100, 100), "Time: " + contagem, DefaultStyle); // Label do cronometro;
	}
	void mission ()
	{
		if (RandomBalls.Score == 45 && time < 110) // Verifica a missao e defini se o player cumpriu a missao;
		{
			Win = true; // Player Venceu;
		}
		if (RandomBalls.Score < 45 && time > 110) // Verifica a missao e defini se o player nao cumpriu a missao;
		{
			Wrong = true; // Player Perdeu;
		}
	}
}