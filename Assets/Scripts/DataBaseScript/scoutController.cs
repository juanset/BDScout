using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;

public class scoutController : MonoBehaviour {

	public int setJogo;
	public int tempo;
	public int ataque;
	public int ponto;
	public int erro;
	public int bloqueio;
	public int saque_flutuante;
	public int contra_ataque;
	public int saque_viagem;
	public int trajetoria;
	public int bola_rapida;
	public int bola_alta;
	public int bola_media;

	public int ponto_adv;
	public int ponto_equipe;

	public Text pontosEquipe;
	public Text pontoSAdversario;

	public float segundos;
	public float minutos;
	public float horas;

	public Text relogio;


	// Use this for initialization
	void Start () {

		ataque = 0;
		erro = 0;
		bloqueio = 0;
		saque_viagem = 0;
		saque_flutuante = 0;
		contra_ataque = 0;

		ponto_equipe = 0;
		ponto_adv = 0;

		segundos = 00;
		minutos = 00;

		StartSync ();
	}


	void Update()
	{
		relogioJogo ();

	}

	public void relogioJogo()
	{
		
		segundos += Time.deltaTime;

		if (segundos >= 60) 
		{
			minutos++;
			segundos = 0;
			//Debug.Log ("ok");
		}
			
		relogio.text = "Tempo: " + minutos.ToString () + " minuto(s)";

		Debug.Log ("Segundos " + segundos + " --- Minutos " + minutos);

	}

	public void zerarTempo()
	{
		segundos = 0;
		minutos = 0;
	}

	public void confirmaPonto()
	{
		//ponto_equipe++;
		Debug.Log ("Placar " + ponto_equipe + " x " + ponto_adv);

		pontosEquipe.text = ponto_equipe.ToString ();
		pontoSAdversario.text = ponto_adv.ToString ();

	}

	public void confirmaAtaque()
	{
		ataque = 1;
		ponto_equipe++;
	}

	public void confirmaErro()
	{
		erro = 1;
		ponto_adv++;
	}

	public void confirmaBloqueio()
	{
		bloqueio = 1;
		ponto_equipe++;
	}

	public void confirmaSV()
	{
		saque_viagem = 1;
		ponto_equipe++;
	}

	public void contraAtaque()
	{
		contra_ataque = 1;
		ponto_equipe++;
	}
		
	private void StartSync()
	{
		var ds = new DataService ("dataBaseScout.db");

		ds.criarScout (ataque, erro, bloqueio, contra_ataque);
	}

	public void confirmaRegistro()
	{
		var ds = new DataService ("dataBaseScout.db");

		ds.criarScoutDB (ataque, erro, bloqueio, contra_ataque);

	}


}
