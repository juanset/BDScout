using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using System.Collections.Generic;


public class equipeSelect : MonoBehaviour {
    public Text DebugText;
    public Dropdown equipito;

    public Text EquipeS;
    // Use this for initialization
    private void Start()
    {
        
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
                    var eqNome = x.nome.ToString();
                    EquipeS.text = eqNome.ToString();
                }
                break;
            case 2:
				ToConsole("Bucando equipos Feminino");
                equipe = ds.GetEquipeName("Feminino");
                ToConsole("Equipos: ");
                ToConsole(equipe);
                foreach (var x in equipe)
                {
                    var eqNome = x.nome.ToString();
                    EquipeS.text = eqNome.ToString();
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
   
    private void ToConsole(string msg)
    {
        DebugText.text += System.Environment.NewLine + msg;
        Debug.Log(msg);
    }
    
    //ejemplo para manejar el dropdown
    public void DropdownInput(int input) {
        Debug.Log("Seleccionada: " + input);
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public void MostrarTodosEquipos(int valor)
    {
        valor.ToString();
        var ds = new DataService("dataBaseScout.db");
        ToConsole("Empieza la busqueda " + valor);
        var equipe = ds.GetAddressEquipe();

        switch (valor)
        {
            case 1:
                ToConsole("Bucando TODOS");
                equipe = ds.GetEquipeName();
                ToConsole("AllTeams: ");
                ToConsole(equipe);
                foreach (var x in equipe)
                {
                    var eqNome = x.nome.ToString();
                    EquipeS.text = eqNome.ToString();
                    //equipito.options.Add(new Dropdown.OptionData() { text = eqNome });
                            
                }
                equipito.RefreshShownValue();
                break;
            case 2:
                ToConsole("Bucando ALL");
                equipe = ds.GetEquipeName();
                ToConsole("ALL Equipos: ");
                ToConsole(equipe);
                foreach (var x in equipe)
                {
                    var eqNome = x.nome.ToString();
                    EquipeS.text = eqNome.ToString();
                    //equipito.options.Add(new Dropdown.OptionData() { text = eqNome});
                }
                equipito.RefreshShownValue();
                break;
        }
        equipito.value = 1;
        equipito.value = 0;
        equipito.RefreshShownValue();
        ToConsole("Finaliza la búsqueda");
    }
}
