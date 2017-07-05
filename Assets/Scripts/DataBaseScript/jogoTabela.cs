using SQLite4Unity3d;

public class jogoTabela {

	[PrimaryKey, AutoIncrement]
	public int id { get; set; }
	public string adversario { get; set; }
	public string campeonato { get; set; }
	public string ginasio { get; set; }
	public string tipo { get; set; }
	public string equipe { get; set; }
	public string etapa { get; set; }
	public string local { get; set; }
	public string data { get; set; }
	public string horario { get; set; }

	public override string ToString ()
	{
		return string.Format ("[jogoTabela: id={0}, adversario={1}, campeonato={2}, ginasio={3}, tipo={4}, equipe={5}, etapa={6}, local={7}, data={8}, horario={9}]", id, adversario, campeonato, ginasio, tipo, equipe, etapa, local, data, horario);
	}
}
