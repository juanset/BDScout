using SQLite4Unity3d;

public class jogadorTabela
{
	[PrimaryKey, AutoIncrement]
	public int id { get; set; }
	public string nome { get; set; }
	public string sobrenome { get; set; }
	public string apelido { get; set; }
	public string genero { get; set; }
	public string nascimento { get; set; }
	public string posicao { get; set; }
	public string numero { get; set; }
	public string lateralidade { get; set; }
	public string altura { get; set; }
	public string peso { get; set; }


	public override string ToString ()
	{
		return string.Format ("[jogadorTabela: id={0}, nome={1}, sobrenome={2}, apelido={3}, genero={4}, nascimento={5}, posicao={6}, numero={7}, lateralidade={8}, altura={9}, peso={10}]", id, nome, sobrenome, apelido, genero, nascimento, posicao, numero, lateralidade, altura, peso);
	}
}
