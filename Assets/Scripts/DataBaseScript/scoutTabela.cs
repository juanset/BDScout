using SQLite4Unity3d;

public class scoutTabela {

	[PrimaryKey, AutoIncrement]
	public int id { set; get; }
	public int id_jogador { set; get; }
	public int id_jogo { set; get; }
	public int ataque { set; get; }
	public int erro { set; get; }
	public int bloqueio { set; get; }
	public int contra_ataque { set; get; }


	public override string ToString ()
	{
		return string.Format ("[scoutTabela: id={0}, id_jogador={1}, id_jogo={2}, ataque={3}, erro={4}, bloqueio={5}, contra_ataque={6}]", id, id_jogador, id_jogo, ataque, erro, bloqueio, contra_ataque);
	}
}
