using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class jogadorController : MonoBehaviour {


	public InputField nome;
	public InputField sobrenome;
	public InputField apelido;
	public InputField genero;
	public InputField nascimento;
	public InputField posicao;
	public InputField numero;
	public InputField lateralidade;
	public InputField altura;
	public InputField peso;

	public string nomeS;
	public string sobrenomeS;
	public string apelidoS;
	public string generoS;
	public string nascimentoS;
	public string posicaoS;
	public string numeroS;
	public string lateralidadeS;
	public string alturaS;
	public string pesoS;


	// Use this for initialization
	void Start () {
		StartSync ();
	}
	
	private void StartSync ()
	{
		var ds = new DataService ("dataBaseScout.db");

		ds.criarJogador (nomeS, sobrenomeS, apelidoS, generoS, nascimentoS, posicaoS, numeroS, lateralidadeS, alturaS, pesoS);


	}

	public void cadastroJogador()
	{
		var ds = new DataService ("dataBaseScout.db");

		nomeS = nome.text.ToString ();
		sobrenomeS = sobrenome.text.ToString ();
		apelidoS = apelido.text.ToString ();
		generoS = genero.text.ToString ();
		nascimentoS = nascimento.text.ToString ();
		posicaoS = posicao.text.ToString ();
		numeroS = numero.text.ToString ();
		lateralidadeS = lateralidade.text.ToString ();
		alturaS = altura.text.ToString ();
		pesoS = peso.text.ToString ();

		ds.criarJogadorDB (nomeS, sobrenomeS, apelidoS, generoS, nascimentoS, posicaoS, numeroS, lateralidadeS, alturaS, pesoS);

	}
}
