using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class jogoController : MonoBehaviour {

	public InputField adversario;
	//public InputField campeonato;
	public InputField ginasio;
	//public InputField tipo;
	public InputField horario;
	//public InputField equipe;
	public InputField etapa;
	public InputField local;
	public InputField data;

	public string adversarioS;
	public string campeonatoS;
	public string ginasioS;
	public string tipoS;
	public string horarioS;
	public string equipeS;
	public string etapaS;
	public string localS;
	public string dataS;

	// Use this for initialization
	void Start () {
		StartSync ();
	}


	private void StartSync()
	{
		var ds = new DataService ("dataBaseScout.db");

		ds.criarJogo (adversarioS, campeonatoS, ginasioS, tipoS, horarioS, equipeS, etapaS, localS, dataS);


	}
	

	public void cadastrarJogo () 
	{
		var ds = new DataService ("dataBaseScout.db");

		adversarioS = adversario.text.ToString ();
		//campeonatoS = campeonato.text.ToString ();
		ginasioS = ginasio.text.ToString ();
		//tipoS = tipo.text.ToString ();
		horarioS = horario.text.ToString ();
		//equipeS = equipe.text.ToString ();
		etapaS = etapa.text.ToString ();
		localS = local.text.ToString ();
		dataS = data.text.ToString ();

		ds.criarJogoDB (adversarioS, campeonatoS, ginasioS, tipoS, horarioS, equipeS, etapaS, localS, dataS);

	}
}
