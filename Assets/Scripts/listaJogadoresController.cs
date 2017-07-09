using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class listaJogadoresController : MonoBehaviour {


	public List <GameObject> jogadorNovo;
	public GameObject grupoJogadores;
	public int idJogadorNovo = 0;

	public Text nomeJogador;

	public RectTransform grid;

	public void addJogador()
	{
		if (grid.childCount < jogadorNovo.Count)
		{
			GameObject itemJogador = Instantiate (jogadorNovo [grid.childCount], grid.position, Quaternion.identity) as GameObject;
			itemJogador.transform.parent = grid.transform;
			itemJogador.name = "Jogador" + idJogadorNovo;
		}

		idJogadorNovo++;
	}

	public void listarJogadores()
	{
		var ds = new DataService ("dataBaseScout.db");
		var jogador = ds.GetAddressJogadores ();


		foreach (var x in jogador) 
		{
			var jogadores = x.nome.ToString();

			nomeJogador.text = x.nome.ToString ();

			Debug.Log (jogadores);
		}

	}


	// Use this for initialization
	void Start () {
		listarJogadores ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
