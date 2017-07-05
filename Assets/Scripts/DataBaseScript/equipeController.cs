using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class equipeController : MonoBehaviour {


	public InputField nome;
	public InputField tecnico;
	public InputField assistente;
	public InputField categoria;
	public InputField genero;

	public string nomeS;
	public string tecnicoS;
	public string assistenteS;
	public string categoriaS;
	public string generoS;

	// Use this for initialization
	void Start () {
		StartSync ();
	}
	
	private void StartSync()
	{
		var ds = new DataService ("dataBaseScout.db");

		ds.criarEquipe (nomeS, tecnicoS, assistenteS, categoriaS, generoS);

	}

	public void cadastroEquipe()
	{
		var ds = new DataService ("dataBaseScout.db");

		nomeS = nome.text.ToString ();
		tecnicoS = tecnico.text.ToString ();
		assistenteS = assistente.text.ToString ();
		categoriaS = categoria.text.ToString ();
		generoS = genero.text.ToString ();
	
		ds.criarEquipeDB (nomeS, tecnicoS, assistenteS, categoriaS, generoS);
	}


}
