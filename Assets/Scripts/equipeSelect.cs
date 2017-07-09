using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using System.Collections.Generic;


public class equipeSelect : MonoBehaviour {
    public Text DebugText;
    public Dropdown genero;

    public Text EquipeS;

	public List <GameObject> equipeNova;
	public GameObject grupoEquipe;
	public int idEquipeNova = 0;

	public RectTransform grid;


	public void addEquipes()
	{
		if (grid.childCount < equipeNova.Count) {
			GameObject item =  Instantiate (equipeNova[grid.childCount], grid.position,Quaternion.identity) as GameObject;
			item.transform.parent = grid.transform;
			item.name = "EquipeNova" + idEquipeNova;

		}
		Debug.Log (idEquipeNova);

		idEquipeNova++;
	}


    // Use this for initialization
    private void Start()
    {

		addEquipes ();
    }
    
    public void SeleccionarEquipo (int genero) {
        genero.ToString();
        var ds = new DataService("dataBaseScout.db");
        ToConsole("Empieza la busqueda" + genero);
        var equipe = ds.GetAddressEquipe();

        switch (genero) { 
            case 1:
                ToConsole("Bucando equipos Masculinos");
                equipe = ds.GetEquipeName("Masculino");
                ToConsole("Equipos: ");
                ToConsole(equipe);
                foreach (var x in equipe) {
                    var hola = x.nome.ToString();
                    EquipeS.text = hola.ToString();
                }
                break;
            case 2:
				ToConsole("Bucando equipos Feminino");
                equipe = ds.GetEquipeName("Feminino");
                ToConsole("Equipos: ");
                ToConsole(equipe);
                foreach (var x in equipe)
                {
                    var hola = x.nome.ToString();
                    EquipeS.text = hola.ToString();
                }
                break;
        }
        ToConsole("Finaliza la búsqueda");
    }

    private void ToConsole(IEnumerable<equipeTabela> x)
    {
        foreach (var equipo in x)
        {
            equipo.nome.ToString();
            ToConsole(equipo.ToString().ToUpper());
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
   
    private void ToConsole(string msg)
    {
        DebugText.text += System.Environment.NewLine + msg;
        Debug.Log(msg);
    }
    public void DropdownInput(int input) {
        Debug.Log("Seleccionada: " + input);
    }

}
