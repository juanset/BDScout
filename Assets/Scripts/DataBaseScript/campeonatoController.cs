using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class campeonatoController : MonoBehaviour {


	public InputField nome;
	public InputField equipe;
	public InputField local;
	public InputField data;

	public string nomeS;
	public string equipeS;
	public string localS;
	public string dataS;


	// Use this for initialization
	void Start () {
		StartSync ();
	}
	
	private void StartSync()
	{
		var ds = new DataService ("dataBaseScout.db");

		ds.criarCampeonato (nomeS, equipeS, localS, dataS);

	}


	public void cadastroCampeonato()
	{
		var ds = new DataService ("dataBaseScout.db");

		nomeS = nome.text.ToString ();
		equipeS = equipe.text.ToString ();
		localS = local.text.ToString ();
		dataS = data.text.ToString ();

		ds.criarCampeonatoDB (nomeS, equipeS, localS, dataS);
	}
}
