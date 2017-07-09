using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Serialization;



public class listaJogosController : MonoBehaviour {

	public List <GameObject> jogoNovo;
	public GameObject grupoJogos;
	public int idJogoNovo = 0;
    public Text linkResultados;


    public RectTransform grid;

	public Text data;
	public Text adversario;

	public void addJogos()
	{
		if (grid.childCount < jogoNovo.Count)
		{
			GameObject itemJogo = GameObject.Instantiate (jogoNovo [grid.childCount], grid.position, Quaternion.identity) as GameObject;
			itemJogo.transform.parent = grid.transform;
			itemJogo.name = "JogoNovo" + idJogoNovo;
		}

		Debug.Log (idJogoNovo);
		idJogoNovo++;
	}

	public void listarJogos()
	{
		var ds = new DataService ("dataBaseScout.db");
		var jogos = ds.GetAddressJogos ();

		foreach (var x in jogos) 
		{
			var jogo = x.adversario.ToString ();
			var idJogo = x.id.ToString ();

            GameObject itemJogo = GameObject.Instantiate(jogoNovo[grid.childCount], grid.position, Quaternion.identity) as GameObject;
            itemJogo.transform.parent = grid.transform;
            itemJogo.name = "JogoNovo" + x;
            data.text = x.data.ToString ();
			adversario.text  = x.adversario.ToString ();
            linkResultados.text = "ID"+ x.id;
		
			Debug.Log (data + " " + adversario);
		}
			
	}
		
	// Use this for initialization
	void Start () {

		listarJogos ();
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
