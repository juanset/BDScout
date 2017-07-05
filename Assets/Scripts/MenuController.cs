using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	//controle do menu
	public void ChangeScene(string sceneName)
	{

		Application.LoadLevel(sceneName);

	}

	public void ExitGame ()
	{
		Application.Quit ();
	}

}
