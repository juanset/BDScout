using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;

public class equipeJogadoresController : MonoBehaviour {

	public Text nomeEquipe;
	public Text nomeTecnico;
	public Text nomeAssistente;
	public Text generoEquipe;
	public Text categoriaEquipe;


	// Use this for initialization
	void Start () {

		var ds = new DataService ("dataBaseScout.db");

		//var e = ds.GetEquipeNome (id);



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
