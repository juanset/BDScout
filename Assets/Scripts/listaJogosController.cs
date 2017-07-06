using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class listaJogosController : MonoBehaviour {

	public List <GameObject> jogoNovo;
	public GameObject grupoJogos;
	public int idJogoNovo = 0;

	public RectTransform grid;


	public void addJogos()
	{
		if (grid.childCount < jogoNovo.Count)
		{
			GameObject itemJogo = Instantiate (jogoNovo [grid.childCount], grid.position, Quaternion.identity) as GameObject;
			itemJogo.transform.parent = grid.transform;
			itemJogo.name = "JogoNovo" + idJogoNovo;
		}

		Debug.Log (idJogoNovo);
		idJogoNovo++;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
