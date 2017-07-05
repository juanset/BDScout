using SQLite4Unity3d;

public class campeonatoTabela
{
	[PrimaryKey, AutoIncrement]
	public int id { get; set; }
	public string nome { get; set; }
	public string equipe { get; set; }
	public string local { get; set; }
	public string data { get; set; }


	public override string ToString ()
	{
		return string.Format ("[cameponatoTabela: id={0}, nome={1}, equipe={2}, local={3}, data={4}]", id, nome, equipe, local, data);
	}

}