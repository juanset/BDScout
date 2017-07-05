using SQLite4Unity3d;

public class equipeTabela
{
	[PrimaryKey, AutoIncrement]
	public int id { get; set; }
	public string nome { get; set; }
	public string tecnico { get; set; }
	public string assistente { get; set; }
	public string categoria { get; set; }
	public string genero { get; set; }

	public override string ToString ()
	{
		return string.Format ("[equipe_T: id={0}, nome={0}, tecnico={1}, assistente={2}, categoria={3}, genero={4}]", nome, tecnico, assistente, categoria, genero);
	}
}
