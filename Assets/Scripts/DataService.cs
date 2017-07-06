using SQLite4Unity3d;
using UnityEngine;
using UnityEngine.UI;
#if !UNITY_EDITOR
using System.Collections;
using System.IO;
#endif
using System.Collections.Generic;

public class DataService : MonoBehaviour {

	private SQLiteConnection _connection;

	private string connectionString;

    public DataService(string DatabaseName){

#if UNITY_EDITOR
            var dbPath = string.Format(@"Assets/StreamingAssets/{0}", DatabaseName);
#else
        // check if file exists in Application.persistentDataPath
        var filepath = string.Format("{0}/{1}", Application.persistentDataPath, DatabaseName);

        if (!File.Exists(filepath))
        {
            Debug.Log("Database not in Persistent path");
            // if it doesn't ->
            // open StreamingAssets directory and load the db ->

#if UNITY_ANDROID 
            var loadDb = new WWW("jar:file://" + Application.dataPath + "!/assets/" + DatabaseName);  // this is the path to your StreamingAssets in android
            while (!loadDb.isDone) { }  // CAREFUL here, for safety reasons you shouldn't let this while loop unattended, place a timer and error check
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDb.bytes);
#elif UNITY_IOS
                 var loadDb = Application.dataPath + "/Raw/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);
#elif UNITY_WP8
                var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
                // then save to Application.persistentDataPath
                File.Copy(loadDb, filepath);

#elif UNITY_WINRT
		var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
		// then save to Application.persistentDataPath
		File.Copy(loadDb, filepath);
#else
	var loadDb = Application.dataPath + "/StreamingAssets/" + DatabaseName;  // this is the path to your StreamingAssets in iOS
	// then save to Application.persistentDataPath
	File.Copy(loadDb, filepath);

#endif

            Debug.Log("Database written");
        }

        var dbPath = filepath;
#endif
            _connection = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        	Debug.Log("Final PATH: " + dbPath);     

	}


	
		
	
	//CRIA EQUIPE
	public void criarEquipe (string nome1, string tecnico1, string assistente1, string categoria1, string genero1)
	{
		connectionString = Application.persistentDataPath + "/tempDatabase.db";

		if (!System.IO.File.Exists (connectionString)) 
		{
			_connection.CreateTable<equipeTabela> ();
		}

		_connection.InsertAll (new[]
		{
			new equipeTabela
			{
				nome = nome1,
				tecnico = tecnico1,
				assistente = assistente1,
				categoria = categoria1,
				genero = genero1
			}
		});

	}

		//CRIA SCOUT
		public void criarScout (int ataque1, int erro1, int bloqueio1, int contraAtaque1)
		{
			connectionString = Application.persistentDataPath + "/tempDatabase.db";

		if (!System.IO.File.Exists (connectionString)) 
		{
			_connection.CreateTable<scoutTabela> ();
		}
			_connection.InsertAll (new[]
		{

			new scoutTabela
			{
				ataque = ataque1,
				erro = erro1,
				bloqueio = bloqueio1,
				contra_ataque = contraAtaque1
			}
		});

		}


	//CRIA CAMPEONATO
		public void criarCampeonato (string nome1, string equipe1, string local1, string data1)
		{
		connectionString = Application.persistentDataPath + "/tempDatabase.db";

		if (!System.IO.File.Exists (connectionString)) 
			{
				_connection.CreateTable<campeonatoTabela> ();
			}
			_connection.InsertAll (new[]
			{

			new campeonatoTabela
				{
					nome = nome1,
					equipe = equipe1,
					local = local1,
					data = data1
				}
			});

		}

		//CRIA JOGADOR
		public void criarJogador (string nome1, string sobrenome1, string apelido1, string genero1, string nascimento1, string posicao1, string numero1, string lateralidade1, string altura1, string peso1)
		{
		connectionString = Application.persistentDataPath + "/tempDatabase.db";

			if (!System.IO.File.Exists (connectionString)) 
			{
				_connection.CreateTable<jogadorTabela> ();
			}
				_connection.InsertAll (new[]
			{
				new jogadorTabela
				{
					nome = nome1,
					sobrenome = sobrenome1,
					apelido = apelido1,
					genero = genero1,
					nascimento = nascimento1,
					posicao = posicao1,
					numero = numero1,
					lateralidade = lateralidade1,
					altura = altura1,
					peso = peso1
				}
			});

		}

		//CRIA JOGOS
		public void criarJogo (string adversario1, string campeonato1, string ginasio1, string tipo1, string horario1, string equipe1, string etapa1, string local1, string data1)
		{
		connectionString = Application.persistentDataPath + "/tempDatabase.db";

		if (!System.IO.File.Exists (connectionString)) 
			{
				_connection.CreateTable<jogoTabela> ();
			}

			_connection.InsertAll (new[]
			{
				new jogoTabela
				{
					adversario = adversario1,
					campeonato = campeonato1,
					ginasio = ginasio1,
					tipo = tipo1,
					horario = horario1, 
					equipe = equipe1,
					etapa = etapa1,
					local = local1,
					data = data1
				}
			});

		}

		//CAMPEONATO
		//public IEnumerable<campeonatoTabela> GetAddressCampeonato(){
		//return _connection.Table<campeonatoTabela>();
		//}


		//EQUIPE SELECIONA GENERO
		public IEnumerable<equipeTabela> GetAddressEquipe(){
			return _connection.Table<equipeTabela>();
		}

		public IEnumerable<equipeTabela> GetEquipeName(string genero)
		{
			return _connection.Table<equipeTabela>().Where(x => x.genero == genero);

		}

		public IEnumerable<equipeTabela> GetEquipeName()
		{
			return _connection.Table<equipeTabela>().Where(x => x.nome == "lolitos");

		}

		//CRIA NA BASE DE DADOS ----SCOUT
		public scoutTabela criarScoutDB(int ataque1, int erro1, int bloqueio1, int contraAtaque1)
		{
			var scout = new scoutTabela
			{
				ataque = ataque1,
				erro = erro1,
				bloqueio = bloqueio1,
				contra_ataque = contraAtaque1

			};
		_connection.Insert (scout);
		return scout;
		}


		//CRIA NA BASE DE DADOS ----EQUIPE
		public equipeTabela criarEquipeDB(string n2, string t2, string a2, string c2, string g2)
		{
			var equipe = new equipeTabela
			{
				nome = n2,
				tecnico = t2,
				assistente = a2,
				categoria = c2,
				genero = g2
				
			};
		_connection.Insert (equipe);
		return equipe;
		}

		//CRIA NA BASE DE DADOS ----CAMPEONATO
		public campeonatoTabela criarCampeonatoDB(string nome1, string equipe1, string local1, string data1)
		{
			var campeonato = new campeonatoTabela
			{
				nome = nome1,
				equipe = equipe1,
				local = local1,
				data = data1
			};

		_connection.Insert (campeonato);
		return campeonato;
		}


		//CRIA NA BASE DE DADOS ----JOGADOR
		public jogadorTabela criarJogadorDB(string nome1, string sobrenome1, string apelido1, string genero1, string nascimento1, string posicao1, string numero1, string lateralidade1, string altura1, string peso1)
		{
			var jogador = new jogadorTabela
				{
					nome = nome1,
					sobrenome = sobrenome1,
					apelido = apelido1,
					genero = genero1,
					nascimento = nascimento1,
					posicao = posicao1,
					numero = numero1,
					lateralidade = lateralidade1,
					altura = altura1,
					peso = peso1
			
				};

			_connection.Insert (jogador);
			return jogador;
		}

		//CRIA NA BASE DE DADOS ----JOGO
		public jogoTabela criarJogoDB(string adversario1, string campeonato1, string ginasio1, string tipo1, string horario1, string equipe1, string etapa1, string local1, string data1)
		{
			var jogo = new jogoTabela
			{
				adversario = adversario1,
				campeonato = campeonato1,
				ginasio = ginasio1,
				tipo = tipo1,
				horario = horario1,
				equipe = equipe1,
				etapa = etapa1,
				local = local1,
				data = data1

			};
		_connection.Insert (jogo);
		return jogo;
		}

}
